using System;
using System.Windows.Forms;

namespace Blackjack_OOP3
{
    internal static class Program
    {
        [STAThread]  // Zorgt voor correcte threading voor Windows Forms
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Form1());  // Zorgt ervoor dat Form1 start
            Application.Run(new Form1());
        }
    }
}
