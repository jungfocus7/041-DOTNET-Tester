//using HPO402.WpfCustomControls.Models;
using HPO402.Common.Models;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;


namespace HPO402.WpfCustomControls
{
    /// <summary>
    /// TextBox는 숫자만 입력이 가능하며 (Tab, Enter)키를
    /// 누르면 가장 가까운 아이템을 검색하여 선택함
    /// </summary>
    public sealed partial class ComboBoxEx01 : ComboBox
    {
        #region ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 1
        public ComboBoxEx01()
        {			
            InitializeComponent();
            //Loaded += prLoaded;
        }

        //private void prLoaded(object sd, System.Windows.RoutedEventArgs ea)
        //{
        //    Loaded -= prLoaded;
        //}


        public TextBox TextBox { get; private set; }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            TextBox = (TextBox)Template.FindName("PART_EditableTextBox", this);
            //TextBox.TextChanged += prTextChanged;
            //TextBox.PreviewTextInput += prPreviewTextInput;
            TextBox.PreviewKeyDown += prPreviewKeyDown;
        }
        #endregion


        //private bool m_bPassEvent = false;
        //private void prTextChanged(object sd, TextChangedEventArgs ea)
        //{
        //    if (m_bPassEvent)
        //    {
        //        m_bPassEvent = false;
        //        return;
        //    }

        //    if (ItemsSource is string[] vals)
        //    {
        //        string txt = TextBox.Text;
        //        if ((string.IsNullOrWhiteSpace(txt) == false) && (txt.Length >= 3))
        //        {
        //            int i = 0;
        //            foreach (string val in vals)
        //            {
        //                if (val.Contains(txt))
        //                {
        //                    SelectedIndex = i;
        //                    m_bPassEvent = true;
        //                    break;
        //                }
        //                ++i;
        //            }
        //        }
        //    }
        //}

        //private void prPreviewTextInput(object sd, TextCompositionEventArgs ea)
        //{
        //}


        public Action<ComboBox> KeyDownCallback;

        private void prPreviewKeyDown(object sd, KeyEventArgs ea)
        {
            if ((sd is TextBox tb) && ((ea.Key == Key.Tab) || (ea.Key == Key.Enter)))
            {
                string txt = tb.Text;
                if ((string.IsNullOrWhiteSpace(txt) == false) && (txt.Length >= 2)
                    && int.TryParse(txt, out int num))
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

                //if (string.IsNullOrWhiteSpace(txt) || (txt.Length < 2)) return;
                //if (int.TryParse(txt, out int num))
                //{
                //    KeyDownCallback?.Invoke(this);

                //    //if (ItemsSource is CaseInfoCollection cis)
                //    //{
                //    //    int i = 0;
                //    //    foreach (CaseInfo ci in cis)
                //    //    {
                //    //        if (ci.Number.Contains(txt))
                //    //        {
                //    //            SelectedIndex = i;
                //    //            ea.Handled = true;
                //    //            break;
                //    //        }
                //    //        ++i;
                //    //    }
                //    //}
                //}
            }
        }

    }
}
