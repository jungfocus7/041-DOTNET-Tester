using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace TesterDXApplication71
{
    public static class TesterProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SkinManager.EnableFormSkins();
            BonusSkins.Register();

            //Skin skin = FormSkins.GetSkin(UserLookAndFeel.Default);
            //SkinElement elem = skin[FormSkins.SkinFormCaption];
            //elem.ContentMargins.Bottom = 5;
            //elem.ContentMargins.Top = 5;
            //elem.Color.ForeColor = Color.White;
            //elem.Color.FontBold = false;
            //elem.Color.FontSize = 50;

            Application.Run(new m_frmMain());
        }
    }
}