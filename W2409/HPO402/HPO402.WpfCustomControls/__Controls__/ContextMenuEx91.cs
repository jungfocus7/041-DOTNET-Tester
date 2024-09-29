using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;


namespace HPO402.WpfCustomControls
{
    public sealed class ContextMenuEx91 : ContextMenu
    {
        private static ContextMenuEx91 _ist;
        public static ContextMenuEx91 Create(UIElement uie, Action<CallbackType, char> cbf)
        {
            if (_ist == null)
                _ist = new ContextMenuEx91(uie, cbf);
            return _ist;
        }


        private ContextMenuEx91(UIElement uie, Action<CallbackType, char> cbf)
        {
            m_mioc = new ObservableCollection<Control>()
            {
                new MenuItem()
                {
                    Header = "1) 삼성전자"
                },
                new MenuItem()
                {
                    Header = "2) 인텔"
                },
                new MenuItem()
                {
                    Header = "3) 마이크로소프트"
                },

                new Separator(),
                new MenuItem()
                {
                    Header = "4) 애플"
                },
                new MenuItem()
                {
                    Header = "5) 오라클"
                },
                new MenuItem()
                {
                    Header = "6) 메타"
                },

                new Separator(),
                new MenuItem()
                {
                    Header = "A) 테슬라"
                },
                new MenuItem()
                {
                    Header = "B) 하이닉스"
                },
                new MenuItem()
                {
                    Header = "C) 어도비"
                }
            };

            Cursor = Cursors.Hand;
            PlacementTarget = uie;
            Placement = PlacementMode.Top;
            ItemsSource = m_mioc;

            uie.PreviewMouseRightButtonDown += prUeptPmrbd;


            foreach (Control tct in m_mioc)
            {
                if (tct is MenuItem mi)
                {
                    string htx = mi.Header.ToString();
                    if (string.IsNullOrWhiteSpace(htx) == false)
                    {
                        char tx = char.ToUpper(htx[0]);
                        mi.Tag = tx;
                    }
                    mi.Click += prMiCl;
                }
            }

            m_cbf = cbf;
        }

        private readonly ObservableCollection<Control> m_mioc;
        private readonly Action<CallbackType, char> m_cbf;


        private void prUeptPmrbd(object sd, MouseButtonEventArgs ea)
        {
            IsOpen = true;
        }

        private void prMiCl(object sd, RoutedEventArgs ea)
        {
            if (sd is MenuItem mi)
            {
                if (mi.Tag is char kc)
                {
                    m_cbf?.Invoke(CallbackType.ItemSelected, kc);
                }
            }
        }

        protected override void OnPreviewKeyDown(KeyEventArgs ea)
        {
            base.OnPreviewKeyDown(ea);


            (MenuItem rmi, char rc) = (null, char.MinValue);

            char kc = (char)KeyInterop.VirtualKeyFromKey(ea.Key);
            foreach (Control tct in m_mioc)
            {
                if (tct is MenuItem mi)
                {
                    string htx = mi.Header.ToString();
                    if (string.IsNullOrWhiteSpace(htx) == false)
                    {
                        char tc = htx[0];
                        if (tc == kc)
                        {
                            rmi = mi;
                            rc = tc;
                            break;
                        }
                    }
                }
            }

            if (rmi != null)
            {
                //Debug.WriteLine(rmi, rn);
                IsOpen = false;
                m_cbf?.Invoke(CallbackType.ItemSelected, rc);
            }
        }


    }
}
