using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesterDXApplication71.Tools;

namespace TesterDXApplication71
{
    public sealed partial class TesterForm : RibbonForm
    {
        public TesterForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs ea)
        {
            base.OnLoad(ea);

            prTesterFormInit();
            prRibbonControlInit();
            prLayoutControlInit();

            TimerTool.DelayCall(
                delegate
                {
                    WindowState = FormWindowState.Maximized;
                }, 1000);
        }

        protected override void OnShown(EventArgs ea)
        {
            base.OnShown(ea);

            //TimerTool.DelayCall(
            //    delegate
            //    {
            //        WindowState = FormWindowState.Maximized;
            //    }, 500);       
        }

        private void prTesterFormInit()
        {
            Text = "[Support Center (Powerd .NET Framework)] - (build: 241003)";
            MinimumSize = new Size(800, 600);

            Screen scr = Screen.FromPoint(MousePosition);
            Rectangle rct = scr.WorkingArea;
            rct.Inflate(-100, -50);
            Bounds = rct;
        }

        private void prRibbonControlInit()
        {
            //m_ribbonControl.Minimized = true;
            m_ribbonControl1.CommandLayout = CommandLayout.Simplified;
        }

        private void prLayoutControlInit()
        {
            m_layoutControlItem1.MaxSize = new Size(500, 1);
            m_layoutControlItem1.MinSize = new Size(200, 1);
            //m_layoutControlItem1.Size = new Size(300, 1);

            m_layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            m_layoutControlItem2.MaxSize = Size.Empty;
            m_layoutControlItem2.MinSize = Size.Empty;
            m_layoutControlItem2.Size = Size.Empty;

            m_layoutControlItem3.MaxSize = new Size(500, 1);
            m_layoutControlItem3.MinSize = new Size(200, 1);
            //m_layoutControlItem3.Size = new Size(300, 1);


            Rectangle rct = m_layoutControlGroup1.Bounds;
            int pl1 = rct.Left + 300;
            m_splitterItem1.Location = new Point(pl1, 0);
            int pl2 = rct.Right - 300;
            m_splitterItem2.Location = new Point(pl2, 0);
        }

    }
}