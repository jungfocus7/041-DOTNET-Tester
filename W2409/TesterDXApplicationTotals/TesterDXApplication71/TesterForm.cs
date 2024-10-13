using DevExpress.Data;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesterDXApplication71.DataProviders;
using TesterDXApplication71.Models;
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

            //TimerTool.DelayCall(
            //    delegate
            //    {
            //        WindowState = FormWindowState.Maximized;
            //    }, 1000);
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
            m_layoutControlItem1.MaxSize = new Size(500, 0);
            m_layoutControlItem1.MinSize = new Size(200, 0);
            //m_layoutControlItem1.Size = new Size(300, 0);

            m_layoutControlItem2.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            m_layoutControlItem2.MaxSize = Size.Empty;
            m_layoutControlItem2.MinSize = Size.Empty;
            m_layoutControlItem2.Size = Size.Empty;

            m_layoutControlItem3.MaxSize = new Size(500, 0);
            m_layoutControlItem3.MinSize = new Size(200, 0);
            //m_layoutControlItem3.Size = new Size(300, 0);


            Rectangle rct = m_layoutControlGroup1.Bounds;
            int pl1 = rct.Left + 300;
            m_splitterItem1.Location = new Point(pl1, 0);
            int pl2 = rct.Right - 300;
            m_splitterItem2.Location = new Point(pl2, 0);


            prTreeList32_InitOnce();
        }


        private void prTreeList32_InitOnce()
        {
            m_trl32.LookAndFeel.UseDefaultLookAndFeel = false;
            m_trl32.LookAndFeel.Style = LookAndFeelStyle.Office2003;

            m_trl32.Appearance.FocusedRow.Options.UseBackColor = true;
            m_trl32.Appearance.FocusedRow.GradientMode = LinearGradientMode.Vertical;
            m_trl32.Appearance.FocusedRow.BackColor = Color.Gainsboro;
            m_trl32.Appearance.FocusedRow.BackColor2 = Color.MintCream;
            m_trl32.Appearance.FocusedRow.ForeColor = Color.Navy;


            m_trl32.OptionsView.AutoWidth = false;
            //m_trl32.OptionsView.ShowButtons = false;
            //m_trl32.OptionsView.ShowIndicator = false;
            m_trl32.OptionsBehavior.Editable = false;
            m_trl32.OptionsSelection.EnableAppearanceFocusedRow = true;
            m_trl32.OptionsSelection.EnableAppearanceFocusedCell = false;

            //m_trl32.OptionsView.EnableAppearanceEvenRow = false;
            //m_trl32.OptionsView.EnableAppearanceOddRow = true;
            //m_trl32.ViewStyle = TreeListViewStyle.TreeList;


            //m_trl32.Columns.AddVisible("Level");
            //m_trl32.Columns.AddVisible("Num");
            //m_trl32.Columns.AddVisible("Text");
            //m_trl32.DataSource = new VirtualRecordInfo();
        }


        private void prBarButtonItemAllItemClick(object sd, ItemClickEventArgs ea)
        {
            //m_trl32.BeginUpdate();
            //m_trl32.BeginUnboundLoad();


            DefaultProvider.LoadData();

            m_trl32.Columns.AddRange(new TreeListColumn[]
            {
                new TreeListColumn()
                {
                    Caption = "번호",
                    FieldName = "Num",
                    Visible = true,
                },
                new TreeListColumn()
                {
                    Caption = "기준일자",
                    FieldName = "BaseDate",
                    Visible = true,
                },
                new TreeListColumn()
                {
                    Caption = "문건명",
                    FieldName = "DocumentName",
                    Visible = true,
                },
                new TreeListColumn()
                {
                    Caption = "제출자",
                    FieldName = "Submitter",
                    Visible = true,
                },
                new TreeListColumn()
                {
                    Caption = "진행",
                    FieldName = "ProgrssState",
                    Visible = true,
                },
                new TreeListColumn()
                {
                    Caption = "시작페이지",
                    FieldName = "StartPage",
                    Visible = true,
                }
            });
            m_trl32.ParentFieldName = "PNum";
            m_trl32.KeyFieldName = "Num";
            //m_trl32.Columns.AddVisible("PNum");
            //m_trl32.Columns.AddVisible("Num");
            //m_trl32.BeginInvoke((MethodInvoker)delegate
            //{
            //    m_trl32.DataSource = DefaultProvider.RecordInfos;
            //});
            m_trl32.DataSource = DefaultProvider.RecordInfos;
            //m_trl32.Columns["BaseDate"].Caption = "기준일자";
            //m_trl32.Columns["DocumentName"].Caption = "문건명";
            //m_trl32.Columns["Submitter"].Caption = "제출자";
            //m_trl32.Columns["ProgrssState"].Caption = "진행";
            //m_trl32.Columns["StartPage"].Caption = "시작페이지";


            //m_trl32.ExpandAll();
            m_trl32.BestFitColumns();
            m_trl32.ForceInitialize();


            //m_trl32.EndUpdate();
            //m_trl32.EndUnboundLoad();
        }

    }
}