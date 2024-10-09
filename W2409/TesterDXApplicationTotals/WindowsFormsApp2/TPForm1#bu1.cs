using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public sealed partial class TPForm1 : Form
    {
        public TPForm1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs ea)
        {
            base.OnLoad(ea);

            m_trl31.BeginInit();
            m_trl31.BeginUpdate();
            m_trl31.BeginUnboundLoad();
            for (int i = 0; i < 999; ++i)
            {
                m_trl31.AppendNode(
                    new object[]
                    {
                    "크레용",
                    "피의자자백서",
                    "의견"
                    }, 1);
            }

            for (int i = 0; i < 9999; ++i)
            {
                m_trl31.AppendNode(
                    new object[]
                    {
                    "크레용",
                    "피의자자백서",
                    "의견"
                    }, -1);
            }
            m_trl31.EndUnboundLoad();
            m_trl31.EndUpdate();
            m_trl31.EndInit();


            m_sbt31.Click += delegate
            {
                prTreeListUpdate();
            };

            m_sbt32.Click += delegate
            {
                //m_trl31.BestFitColumns(true);
                m_trl31.ExpandAll();
                m_trl31.ForceInitialize();
                m_trl31.BestFitColumns();
            };
        }

        private void prTreeListUpdate()
        {
            m_trl31.BeginUpdate();

            m_trl31.Columns.Clear();
            m_trl31.ClearNodes();

            m_trl31.OptionsView.ShowIndicator = false;
            m_trl31.OptionsView.AutoWidth = false;
            m_trl31.OptionsBehavior.Editable = false;
            //m_trl31.OptionsBehavior.ReadOnly = true;
            m_trl31.ParentFieldName = "Pid";
            m_trl31.KeyFieldName = "Id";

            BindingList<RowItem> lst = new BindingList<RowItem>();
            for (int i = 0; i < 100000; ++i)
            {
                int num = i + 1;

                if ((num >= 1) && (num <= 10))
                {
                    RowItem ri = new RowItem()
                    {
                        Pid = 3,
                        Id = num,
                        Num = num.ToString().PadLeft(6, '0'),
                        Name = "임헌진"
                    };
                    lst.Add(ri);
                }
                else if ((num >= 900) && (num <= 980))
                {
                    RowItem ri = new RowItem()
                    {
                        Pid = 30,
                        Id = num,
                        Num = num.ToString().PadLeft(6, '0'),
                        Name = "정희범"
                    };
                    lst.Add(ri);
                }
                else
                {
                    RowItem ri = new RowItem()
                    {
                        Pid = -1,
                        Id = num,
                        Num = num.ToString().PadLeft(6, '0'),
                        Name = "박종명"
                    };
                    lst.Add(ri);
                }
            }
            //lst.Add(new RowItem()
            //{
            //    Pid = -1,
            //    Id = 1,
            //    Num = "000001",
            //    Name = "박종명"
            //});
            //lst.Add(new RowItem()
            //{
            //    Pid = -1,
            //    Id = 2,
            //    Num = "000002",
            //    Name = "박종명"
            //});
            //lst.Add(new RowItem()
            //{
            //    Pid = -1,
            //    Id = 3,
            //    Num = "000003",
            //    Name = "박종명"
            //});
            m_trl31.DataSource = lst;

            //foreach (TreeListColumn tlc in m_trl31.Columns)
            //{
            //    if (tlc.FieldName == "Pid")
            //    {
            //        tlc.Visible = false;
            //    }
            //    else if (tlc.FieldName == "Id")
            //    {
            //        tlc.Visible = false;
            //    }
            //    else if (tlc.FieldName == "Num")
            //    {
            //        //tlc.OptionsColumn.AllowSize = true;
            //        tlc.Width = 80;
            //    }
            //    else if (tlc.FieldName == "Name")
            //    {
            //        //tlc.OptionsColumn.AllowSize = false;
            //        tlc.Width = 100;
            //    }
            //}

            //m_trl31.Columns.RemoveAt(0);
            //m_trl31.Columns.RemoveAt(0);
            m_trl31.Columns["Num"].Width = 80;
            m_trl31.Columns["Name"].Width = 120;

            m_trl31.EndUpdate();

            //m_trl31.BestFitColumns();


            m_trl31.ExpandAll();
            m_trl31.ForceInitialize();
            m_trl31.BestFitColumns();



            m_xtp31.Text = $"검사({lst.Count})";


            m_trl31.BeforeCollapse += delegate (object sd, BeforeCollapseEventArgs ea)
            {
                ea.CanCollapse = false;
            };

            m_trl31.BeforeExpand += delegate (object sd, BeforeExpandEventArgs ea)
            {
                ea.CanExpand = false;
            };
        }
    }


    public sealed class RowItem
    {
        public int Pid { get; set; }
        public int Id { get; set; }
        public string Num { get; set; }
        public string Name { get; set; }
    }
}
