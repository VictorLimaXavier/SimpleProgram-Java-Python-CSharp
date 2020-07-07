using System;
using System.Windows.Forms;
using QECGUI = gui.QECGUI;
namespace QuadraticEquationCalculator
{
    public class QuadraticEquationCalculator{
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QECGUI());
        }
    }
}
