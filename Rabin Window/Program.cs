using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rabin_Window.BL;
using StartMenu;

namespace Rabin_Window
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

            MainForm form = new MainForm();
            MessageService service = new MessageService();
            FileManager manager = new FileManager();
            MenuForm menuForm = new MenuForm();

            MainPresentor presentor = new MainPresentor(form, manager, service,menuForm);


            Application.Run(menuForm);
        }
    }
}
