using HPO402.Common.Helpers;
using HPO402.WpfCustomControls;
using HPO402.WpfRoot.DataProviders;
using HPO402.WpfRoot.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace HPO402.WpfRoot
{
    /// <summary>
    /// RootContainer.xaml에 대한 상호 작용 논리
    /// </summary>
    public sealed partial class RootContainer : UserControl
    {
        public RootContainer()
        {
            InitializeComponent();
            Loaded += prLoaded;
        }

        private void prLoaded(object sd, RoutedEventArgs ea)
        {
            Loaded -= prLoaded;

            MainHelper.InitOnce(this);

            DefaultProvider.LoadData();

            m_cbbex11.DisplayMemberPath = DefaultProvider.CaseInfosDisplayMemberPath;
            m_cbbex11.ItemsSource = DefaultProvider.ServerInfos;
            m_cbbex11.SelectedIndex = 0;

            m_cbbex21.DisplayMemberPath = DefaultProvider.UserInfosDisplayMemberPath;
            m_cbbex21.ItemsSource = DefaultProvider.UserInfos;
            m_cbbex21.SelectedIndex = 0;

            m_cbbex31.DisplayMemberPath = DefaultProvider.CaseInfosDisplayMemberPath;
            m_cbbex31.ItemsSource = DefaultProvider.CaseInfos;
            m_cbbex31.SelectedIndex = 0;


            m_cme91 = ContextMenuEx91.Create(m_btn91,
                delegate (CallbackType cbt, char rc)
                {
                    Debug.WriteLine($"~~~~~~~~~~{rc}");
                });

            m_cme31 = ContextMenuEx31.Create(m_btn31,
                delegate (CallbackType cbt, char rc)
                {
                    Debug.WriteLine($"~~~~~~~~~~{rc}");
                });
        }

        private ContextMenuEx91 m_cme91;
        private ContextMenuEx31 m_cme31;
    }
}
