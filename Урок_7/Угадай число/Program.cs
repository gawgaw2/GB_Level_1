using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Угадай_число
{
    static class Program
    {
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(0, 100);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
          
            // НЕ ПОЙМУ КАК ПРИЦЕПИТЬСЯ К МЕТКЕ НА ФОРМЕ!!!
            
           
        }

    }
}
