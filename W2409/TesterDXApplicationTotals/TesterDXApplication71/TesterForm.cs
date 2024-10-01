using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TesterDXApplication71
{
    public sealed partial class m_frmMain : RibbonForm
    {
        public m_frmMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs ea)
        {
            base.OnLoad(ea);

            Text = "[Support Center v1.23.3] - Powerd Applyerd.";
            MinimumSize = new Size(800, 600);

            prRibbonControlSettings();
        }

        private void prRibbonControlSettings()
        {
            //m_ribbonControl.Minimized = true;
            m_ribbonControl.CommandLayout = CommandLayout.Simplified;
        }
    }
}