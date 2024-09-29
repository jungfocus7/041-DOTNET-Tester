//using HPO402.WpfCustomControls.Models;
using HPO402.Common.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Xml.Linq;

namespace HPO402.WpfCustomControls
{
    /// <summary>
    /// TextBox는 숫자만 입력이 가능하며 (Tab, Enter)키를
    /// 누르면 가장 가까운 아이템을 검색하여 선택함
    /// </summary>
    public sealed partial class ComboBoxEx31 : ComboBox
    {
        #region [01: 객체 초기화 영역]
        public ComboBoxEx31()
        {			
            InitializeComponent();
            Loaded += prLoaded;
        }

        private void prLoaded(object sd, RoutedEventArgs ea)
        {
            Loaded -= prLoaded;
        }


        public TextBox TextBox { get; private set; }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            TextBox = (TextBox)Template.FindName("PART_EditableTextBox", this);
            TextBox.PreviewKeyDown += prPreviewKeyDown;

            prContextMenuSetting();

            prTestBench();
        }

        private void prTestBench()
        {   
            try
            {
                string xaml = XamlWriter.Save(Template);
                XDocument xd = XDocument.Parse(xaml);
                xaml = xd.ToString();
                
            }
            catch { }
        }
        #endregion

        private void prPreviewKeyDown(object sd, KeyEventArgs ea)
        {
            if ((sd is TextBox tb) && ((ea.Key == Key.Tab) || (ea.Key == Key.Enter)))
            {
                string txt = tb.Text;
                if ((string.IsNullOrWhiteSpace(txt) == false) && (txt.Length >= 2))
                {
                    if (ItemsSource is IEnumerable<BaseInfo> bis)
                    {
                        foreach (BaseInfo bi in bis)
                        {
                            string value = bi.GetSearchValue();
                            if (value.Contains(txt))
                            {
                                SelectedItem = bi;
                                break;
                            }
                        }
                    }
                }
            }
        }


        private static ContextMenu m_cm;
        private void prContextMenuSetting()
        {
            if (m_cm == null)
            {
                try
                {
                    m_cm = (ContextMenu)FindResource("key_ContextMenu");
                }
                catch { }
            }

            TextBox.ContextMenu = m_cm;
        }

        private void prMenuItem_Click(object sd, RoutedEventArgs ea)
        {
            Debug.WriteLine(ea);

            MenuItem mi = (MenuItem)sd;
            string code = mi.Tag.ToString();
            if (code == "M01")
            {
            }
            else if (code == "M02")
            {
            }
        }
    }
}
