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


            AllowDrop = true;
            //DragEnter += prDragEnter;
            //DragOver += prDragOver;

        }

        private ContextMenuEx91 m_cme91;
        private ContextMenuEx31 m_cme31;



        //private void prDragEnter(object sd, DragEventArgs ea)
        //{
        //    ea.Handled = true;
        //}

        //private void prDragOver(object sd, DragEventArgs ea)
        //{
        //    ea.Handled = true;
        //}

        //protected override void OnDragEnter(DragEventArgs e)
        //{
        //    base.OnDragEnter(e);
        //}

        //protected override void OnDragLeave(DragEventArgs e)
        //{
        //    base.OnDragLeave(e);
        //}

        //protected override void OnDragOver(DragEventArgs e)
        //{
        //    base.OnDragOver(e);
        //}




        //protected override void OnPreviewDragEnter(DragEventArgs ea)
        //{
        //    base.OnPreviewDragEnter(ea);

        //    //Debug.WriteLine("PreviewDragEnter");
        //}

        //protected override void OnPreviewDragLeave(DragEventArgs ea)
        //{
        //    base.OnPreviewDragLeave(ea);

        //    //Debug.WriteLine("PreviewDragLeave");
        //}

        //protected override void OnPreviewDragOver(DragEventArgs ea)
        //{
        //    base.OnPreviewDragOver(ea);

        //    //Debug.WriteLine("PreviewDragOver");
        //}

        //protected override void OnPreviewDrop(DragEventArgs ea)
        //{
        //    base.OnPreviewDrop(ea);

        //    Debug.WriteLine("PreviewDrop");
        //}



        protected override void OnDragEnter(DragEventArgs ea)
        {
            base.OnDragEnter(ea);

            Debug.WriteLine("DragEnter");

            ea.Effects = DragDropEffects.Scroll;
        }

        protected override void OnDragOver(DragEventArgs ea)
        {
            base.OnDragOver(ea);

            Debug.WriteLine("DragOver");

            ea.Effects = DragDropEffects.Scroll;
        }

        protected override void OnDrop(DragEventArgs ea)
        {
            base.OnDrop(ea);

            Debug.WriteLine("Drop");

            ea.Effects = DragDropEffects.None;

            if (ea.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fpa = (string[])ea.Data.GetData(DataFormats.FileDrop);
                if ((fpa != null) && (fpa.Length == 1))
                {
                    m_txb71.Text = fpa[0];
                }

                //// If the string can be converted into a Brush, allow copying.
                //BrushConverter converter = new BrushConverter();
                //if (converter.IsValid(dataString))
                //{
                //    ea.Effects = DragDropEffects.Copy | DragDropEffects.Move;
                //}
            }
            //if (ea.Data.GetData(DataFormats.FileDrop) is string fp)
            //{

            //}
        }
    }
}
