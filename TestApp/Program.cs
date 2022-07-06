using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    
    public static class Program
    {
        static List<Person> persons = new List<Person>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    public static class CallBackMy
    {
        public delegate void callbackEvent(string what);
        public static callbackEvent callbackEventHandler;
    }
}
