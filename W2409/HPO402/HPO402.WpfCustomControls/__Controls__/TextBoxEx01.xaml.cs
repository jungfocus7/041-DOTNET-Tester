using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Input;


namespace HPO402.WpfCustomControls
{
    public sealed partial class TextBoxEx01 : TextBox
    {
        public TextBoxEx01()
        {
            InitializeComponent();
        }


        protected override void OnPreviewKeyDown(KeyEventArgs ea)
        {
            base.OnPreviewKeyDown(ea);

            bool bOk =
                ((ea.Key >= Key.D0) && (ea.Key <= Key.D9)) ||
                ((ea.Key >= Key.NumPad0) && (ea.Key <= Key.NumPad9)) ||
                (ea.Key == Key.Back) || (ea.Key == Key.Delete) ||
                (ea.Key == Key.Left) || (ea.Key == Key.Right) ||
                (ea.Key == Key.Home) || (ea.Key == Key.End) ||
                (ea.Key == Key.Tab);
            if (bOk == false)
            {
                ea.Handled = true;

                string txt = Text;
                if (string.IsNullOrWhiteSpace(txt)) return;
                if (int.TryParse(txt, out int num))
                {
                    if (ea.Key == Key.Up)
                    {
                        if (ea.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            num += 10;
                        else
                            ++num;
                    }
                    else if (ea.Key == Key.Down)
                    {
                        if (ea.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                            num -= 10;
                        else
                            --num;
                    }

                    if (num < 0)
                        num = 0;

                    string str = num.ToString();
                    if (str.Length <= MaxLength)
                        Text = str;
                }
            }
        }

        protected override void OnMouseWheel(MouseWheelEventArgs ea)
        {
            base.OnMouseWheel(ea);

            string txt = Text;
            if (string.IsNullOrWhiteSpace(txt)) return;
            if (int.TryParse(txt, out int num))
            {
                if (ea.Delta > 0)
                {                    
                    if (Keyboard.Modifiers == ModifierKeys.Shift)
                        num += 10;
                    else
                        ++num;
                }
                else if (ea.Delta < 0)
                {
                    if (Keyboard.Modifiers == ModifierKeys.Shift)
                        num -= 10;
                    else
                        --num;
                }

                if (num < 0)
                    num = 0;

                string str = num.ToString();
                if (str.Length <= MaxLength)
                    Text = str;
            }
        }
    }
}
