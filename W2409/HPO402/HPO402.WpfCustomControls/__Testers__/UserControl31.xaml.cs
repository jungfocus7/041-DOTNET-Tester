using HPO402.Common.EventManages;
using HPO402.Common.Helpers;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;


namespace HPO402.WpfCustomControls
{
    public sealed partial class UserControl31 : UserControl
    {
        public UserControl31()
        {
            InitializeComponent();
            Loaded += prLoaded;
        }

        private void prLoaded(object sd, RoutedEventArgs ea)
        {
            Loaded -= prLoaded;

            //GlobalKeyboardManager.KeyboardEvent += prKeyboardEvent;
            //GlobalKeyboardManager.KeyboardEvent += delegate (object tsd, KeyboardManagerEventArgs tea)
            //{
            //};

            m_pop31.Opened += delegate
            {
                //Keyboard.Focus(m_pop31);
                //var x1 = ((Panel)m_pop31.Child).Children[0];
                //FocusManager.SetFocusedElement(m_pop31, x1);
                //Keyboard.Focus(x1);


                //IInputElement cie = (IInputElement)VisualTreeHelper.GetChild(m_pop31.Child, 0);
                //FocusManager.SetFocusedElement(m_pop31.Child, cie);
                ////Keyboard.Focus(m_pop31);
                //Keyboard.Focus(cie);

                //Dispatcher.BeginInvoke(DispatcherPriority.Render,
                //    (Action)delegate
                //    {
                //        //IInputElement cie = (IInputElement)VisualTreeHelper.GetChild(m_pop31.Child, 0);
                //        //FocusManager.SetFocusedElement(m_pop31.Child, cie);
                //        ////Keyboard.Focus(cie);

                //        var x1 = FocusManager.GetFocusedElement(m_pop31);
                //        var x2 = FocusManager.GetFocusedElement(m_pop31.Child);
                //        var x3 = FocusManager.GetIsFocusScope(m_pop31);
                //        var x4 = FocusManager.GetIsFocusScope(m_pop31.Child);
                //        var x5 = KeyboardNavigation.GetTabNavigation(m_pop31.Child);

                //        var t1 = (FrameworkElement)((FrameworkElement)Parent).Parent;
                //        var x6 = KeyboardNavigation.GetTabNavigation(t1);
                //    });

                //m_pop31.Focus();
                //try
                //{
                //    //Keyboard.ClearFocus();
                //    //IInputElement cie = (IInputElement)VisualTreeHelper.GetChild(m_pop31.Child, 0);
                //    //FocusManager.SetFocusedElement(m_pop31.Child, cie);

                //    Keyboard.ClearFocus();
                //    UIElementCollection uec = ((Panel)m_pop31.Child).Children;
                //    foreach (UIElement ue in uec)
                //    {
                //        if (ue.Focusable)
                //        {
                //            FocusManager.SetFocusedElement(m_pop31.Child, ue);
                //            break;
                //        }
                //        else
                //        {

                //        }
                //    }
                //}
                //catch { }


                GlobalKeyboardManager.KeyboardEvent += prKeyboardEvent;


                //FocusManager.AddGotFocusHandler(m_pop31, delegate (object tsd, RoutedEventArgs tea)
                //{   
                //    Debug.WriteLine($"{tsd},{tea}");

                //    if (tea.Source is UIElement ue)
                //    {
                //        //TraversalRequest tr = new TraversalRequest(FocusNavigationDirection.Last);
                //        ////tr.Wrapped = true;
                //        //ue.MoveFocus(tr);

                //        //ue.PredictFocus(FocusNavigationDirection.);
                //        var x11 = ue.PredictFocus(FocusNavigationDirection.Up);
                //        Keyboard.ClearFocus();
                //        Keyboard.Focus(MainHelper.RootContainer);
                //    }
                //});


                //KeyboardNavigation.SetTabNavigation(m_pop31, KeyboardNavigationMode.Contained);
                //KeyboardNavigation.SetTabNavigation(m_pop31.Child, KeyboardNavigationMode.Contained);

                var x1 = KeyboardNavigation.GetTabNavigation(m_pop31);
                var x2 = KeyboardNavigation.GetTabNavigation(m_pop31.Child);

                var x9 = FocusManager.GetFocusedElement(m_pop31);
                var x8 = FocusManager.GetFocusedElement(m_pop31.Child);


                //FocusManager.SetIsFocusScope(m_pop31, false);
                //FocusManager.SetIsFocusScope(m_pop31.Child, false);
                if (m_pop31.Child is Panel pnl)
                {   
                    foreach (UIElement ue in pnl.Children)
                    {
                        if (ue.Focusable)
                        {
                            //Keyboard.ClearFocus();
                            //FocusManager.SetFocusedElement(pnl, ue);
                            Keyboard.Focus(ue);
                            break;
                        }

                        //FocusManager.SetIsFocusScope(MainHelper.RootContainer, false);
                        //FocusManager.SetFocusedElement(MainHelper.RootContainer, ue);


                        //var x3 = KeyboardNavigation.GetTabNavigation(ue);
                    }
                }
                
            };

            m_pop31.Closed += delegate
            {
                GlobalKeyboardManager.KeyboardEvent -= prKeyboardEvent;
            };

            m_btn31.Click += delegate
            {
                //Keyboard.ClearFocus();
                m_pop31.IsOpen = true;
                if (m_pop31.Child is Panel pnl)
                {
                    pnl.Width = ActualWidth;
                    pnl.Height = ActualHeight;
                }
                //Window wnd = Window.GetWindow(this);
                //wnd.PreviewKeyDown += delegate
                //{
                //    m_pop31.IsOpen = false;
                //};
            };
        }

        private void prKeyboardEvent(object sd, KeyboardManagerEventArgs ea)
        {
            Debug.WriteLine(ea.KeyStr);

            if (ea.KeyStr == Key.Escape.ToString())
            {
                m_pop31.IsOpen = false;
            }
        }

        private void StackPanel_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            //Debug.WriteLine("~~~~~~~~");
        }
    }
}
