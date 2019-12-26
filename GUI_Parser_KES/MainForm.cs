using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Parser_KES
{
    public interface IMainForm
    {
        string FilePath { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);

        event EventHandler FileSelect_Click;
    }
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            butSelectFile.Click += butSelectFile_Click;
        }


        private void butSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XML-файл|*.xml";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fldPath.Text = dlg.FileName;
            }

            if (FileSelect_Click != null) FileSelect_Click(this, EventArgs.Empty);
        }
        public void SetSymbolCount(int count)
        {
            tltCounter.Text = count.ToString();
        }
        public string Content
        {
            get { return fldListPath.Text; }
            set { fldListPath.Text = value; }
        }
        public string FilePath
        {
            get { return fldPath.Text; }
        }

        public event EventHandler FileSelect_Click;
    }
}
