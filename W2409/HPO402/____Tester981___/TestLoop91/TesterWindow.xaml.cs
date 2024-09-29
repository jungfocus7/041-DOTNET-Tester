using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using TestLoop91.CustomControls;


namespace WpfApp1
{
    public sealed partial class TesterWindow : Window
    {
        public TesterWindow()
        {
            InitializeComponent();
            Loaded += prLoaded;
        }

        protected override void OnContentRendered(EventArgs ea)
        {
            base.OnContentRendered(ea);

            SizeToContent = SizeToContent.Manual;
            m_pnlrt.Width = double.NaN;
            m_pnlrt.Height = double.NaN;
        }


        private ContextMenuEx31 m_ctm;

        private void prLoaded(object sd, RoutedEventArgs ea)
        {
            m_ctm = ContextMenuEx31.Create(m_btn31,
                delegate (CallbackType cbt, char rc)
                {
                    //Debug.WriteLine(rc);
                    m_txb31.Text = $"~~~~~~~~~{rc}";
                });
        }
    }
}
