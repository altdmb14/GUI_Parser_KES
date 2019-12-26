using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using FileManager_Parser_KES;

namespace GUI_Parser_KES
{
    public class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IFileManager _manager;
        public string Summary="";
        public int podchet = 0;
        public MainPresenter(IMainForm mainForm, IFileManager manager)
        {
            _view = mainForm;
            _manager = manager;

            _view.FileSelect_Click += _view_FileSelect_Click;
            _view.SetSymbolCount(0);
        }

        private void _view_FileSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string path = _view.FilePath;

                bool isExists = _manager.isExist(path);

                if (!isExists)
                {
                    MessageBox.Show("Ошибка");
                }
                string content = _manager.GetContent(path);
                int count = _manager.GetSymbolCount(content);

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(path);
                XmlElement xRoot = xDoc.DocumentElement;
                XmlNodeList childnodes = xRoot.SelectNodes("//Settings/TrustedZone/ExclutionRules/element/Objects/element/Path");
                foreach (XmlNode n in childnodes)
                {
                    Summary = Summary + '\r' + '\n' + n.InnerText;
                    podchet++;
                }
                     

                _view.Content = Summary;
                _view.SetSymbolCount(podchet);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
