using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public static class TesterProgram1
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TesterForm1());
        }
    }
}
