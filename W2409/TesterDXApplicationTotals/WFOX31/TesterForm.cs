using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
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
using WFOX31.Models;


namespace WFOX31
{
    public sealed partial class TesterForm : Form
    {
        #region ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 0
        public TesterForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs ea)
        {
            base.OnLoad(ea);


            WindowsFormsSettings.DefaultFont = new Font(Font.FontFamily, 10, FontStyle.Regular);

            prPage1Settings();
            prPage2Settings();


            m_sbt31.Click += delegate
            {
                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                m_trl31.ClearAll();
                for (int i = 0; i < 300000; ++i)
                {
                    RecordInfo ri = new RecordInfo()
                    {
                        Data1 = "박종명",
                        Data2 = "임헌진",
                        Data3 = "정희범",
                    };
                    m_recordInfos.Add(ri);
                }

                m_trl31.DataSource = m_recordInfos;
                m_xtp31.Text = $"검사({m_recordInfos.Count})";
            };

            m_sbt32.Click += delegate
            {
                m_trl32.BestFitColumns();

                //m_trl31.ClearAll();
                //m_recordInfos.Clear();
            };
        }
        #endregion



        #region ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 1
        private readonly RecordInfoList m_recordInfos = new RecordInfoList();
        //private readonly BindingSource m_bdsrc = new BindingSource();
        private bool m_bcep = false;

        private void prPage1Settings()
        {
            //m_bdsrc.DataSource = m_recordInfos;

            m_trl31.BeginUpdate();

            m_trl31.OptionsView.AutoWidth = false;
            m_trl31.OptionsView.ShowButtons = false;
            m_trl31.OptionsView.ShowIndicator = false;
            m_trl31.OptionsBehavior.Editable = false;

            m_trl31.ParentFieldName = "Pid";
            m_trl31.KeyFieldName = "Id";


            m_trl31.BeforeCollapse += delegate (object sd, BeforeCollapseEventArgs ea)
            {
                if (m_bcep) return;
                ea.CanCollapse = false;
            };

            m_trl31.BeforeExpand += delegate (object sd, BeforeExpandEventArgs ea)
            {
                if (m_bcep) return;
                ea.CanExpand = false;
            };

            m_trl31.DataSource = m_recordInfos;

            m_trl31.EndUpdate();
        }
        #endregion



        private void prPage2Settings()
        {
            m_trl32.OptionsView.AutoWidth = false;
            //m_trl32.OptionsView.ShowButtons = false;
            //m_trl32.OptionsView.ShowIndicator = false;
            m_trl32.OptionsBehavior.Editable = false;

            //m_trl32.LookAndFeel.UseDefaultLookAndFeel = false;
            m_trl32.OptionsView.EnableAppearanceEvenRow = false;
            m_trl32.OptionsView.EnableAppearanceOddRow = true;

            //m_trl32.ViewStyle = TreeListViewStyle.TreeList;



            m_trl32.Columns.AddVisible("Level");
            m_trl32.Columns.AddVisible("Num");
            m_trl32.Columns.AddVisible("Text");

            m_trl32.DataSource = new VirtualRecordInfo();

            ////m_trl31.BestFitColumns(true);
            m_trl32.ExpandAll();
            m_trl32.ForceInitialize();
            m_trl32.BestFitColumns();
        }

    }
}
