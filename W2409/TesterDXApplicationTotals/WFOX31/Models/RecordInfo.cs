using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace WFOX31.Models
{
    public sealed class RecordInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string pnm = null)
        {
            if (string.IsNullOrWhiteSpace(pnm)) return;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pnm));
        }

        public string Data1 { get; set; }
        public string Data2 { get; set; }
        public string Data3 { get; set; }
    }

    public sealed class RecordInfoList : BindingList<RecordInfo>
    {
    }


    public sealed class VirtualRecordInfo : TreeList.IVirtualTreeListData
    {
        private const int _len = 3;

        public int Level { get; private set; }
        public int Num { get; private set; }

        public string Text { get; private set; }

        private static int _cnt = 0;

        public VirtualRecordInfo()
        {
        }

        private VirtualRecordInfo(int level, int num, string txt)
        {
            Level = level;
            Num = num;
            Text = txt;
        }

        public void VirtualTreeGetChildNodes(VirtualTreeGetChildNodesInfo info)
        {
            if (info.Node is VirtualRecordInfo vri)
            {
                if (vri.Level > 1) return;

                List<VirtualRecordInfo> lst = new List<VirtualRecordInfo>();
                for (int i = 0; i < _len; ++i)
                {
                    int level = vri.Level + 1;
                    int num = i + 1;
                    VirtualRecordInfo ri =
                        new VirtualRecordInfo(level, num, $"Level: {level}, Num: {num}");
                    lst.Add(ri);
                }
                info.Children = lst;
            }

            _cnt++;
        }

        public void VirtualTreeGetCellValue(VirtualTreeGetCellValueInfo info)
        {
            if (info.Node is VirtualRecordInfo vri)
            {
                string fnm = info.Column.FieldName;
                if (fnm == "Level")
                    info.CellData = vri.Level;
                else if (fnm == "Num")
                    info.CellData = vri.Num;
                else if (fnm == "Text")
                    info.CellData = vri.Text;
            }
        }

        public void VirtualTreeSetCellValue(VirtualTreeSetCellValueInfo info)
        {
            if (info.Node is VirtualRecordInfo vri)
            {
                string fnm = info.Column.FieldName;
                if (fnm == "Level")
                    vri.Level = Convert.ToInt32(info.NewCellData);
                else if (fnm == "Num")                    
                    vri.Num = Convert.ToInt32(info.NewCellData);
                else if (fnm == "Text")
                    vri.Text = Convert.ToString(info.NewCellData);
            }
        }
    }
}
