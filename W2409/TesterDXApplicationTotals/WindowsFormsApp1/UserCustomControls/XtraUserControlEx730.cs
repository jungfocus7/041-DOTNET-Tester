using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1.UserCustomControls
{
    #region [00# XtraUserControlEx730]
    public sealed partial class XtraUserControlEx730 : XtraUserControl
    {
        public XtraUserControlEx730()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs ea)
        {
            base.OnLoad(ea);

            Size sz = new Size(200, 200);
            MinimumSize = sz;

            m_spbtn71.MouseDown += delegate
            {
                m_xtce730.Focus();
            };
        }
    }


    public sealed class XtraTabControlEx730 : XtraTabControl
    {
        public XtraTabControlEx730()
        {
            BeginInit();
            SuspendLayout();

            Font ft = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);

            AppearanceObject apo = Appearance;
            apo.Options.UseFont = true;
            apo.Font = ft;

            PageAppearance pga = AppearancePage;
            pga.Header.Options.UseFont = true;
            pga.Header.Font = ft;
            pga.HeaderActive.Options.UseFont = true;
            pga.HeaderActive.Font = new Font(ft.FontFamily, 11.25F, FontStyle.Bold, GraphicsUnit.Point, 129);

            XtraTabPage[] xtpa = new XtraTabPage[]
            {
                new XtraTabPageEx731(),
                new XtraTabPage() { Text = "피고" },
                new XtraTabPage() { Text = "판사" },
            };
            TabPages.AddRange(xtpa);
            SelectedTabPage = xtpa[0];

            EndInit();
            ResumeLayout(false);
        }

        protected override void OnMouseMove(MouseEventArgs ea)
        {
            base.OnMouseMove(ea);

            XtraTabHitInfo xthi = CalcHitInfo(ea.Location);
            if (xthi.HitTest == XtraTabHitTest.PageHeader)
                Cursor = Cursors.Hand;
            else
                Cursor = Cursors.Default;
        }

        protected override void OnMouseLeave(EventArgs ea)
        {
            base.OnMouseLeave(ea);

            Cursor = Cursors.Default;
        }
    }
    #endregion



    #region [01# XtraTabPageEx731]
    public sealed class XtraTabPageEx731 : XtraTabPage
    {
        public XtraTabPageEx731()
        {
            SuspendLayout();

            Text = "검사";
            TreeList = new TreeListEx731();
            Controls.Add(TreeList);

            ResumeLayout(false);
        }

        public TreeListEx731 TreeList { get; private set; }
    }


    public sealed class TreeListEx731 : TreeList
    {
        public TreeListEx731()
        {
            Dock = DockStyle.Fill;
            Location = new Point(1, 25);
        }
    }
    #endregion

}
