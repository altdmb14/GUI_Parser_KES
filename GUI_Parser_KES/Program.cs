using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManager_Parser_KES;

namespace GUI_Parser_KES
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();
            FileManager manager = new FileManager();
            MainPresenter presenter = new MainPresenter(mainForm, manager);

            Application.Run(mainForm);
        }
    }
}
