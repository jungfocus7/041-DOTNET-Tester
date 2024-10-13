using DevExpress.XtraTreeList;
using System;


namespace TesterDXApplication71.ExtendedControls
{
    public sealed class TreeListEx51 : TreeList
    {
        public TreeListEx51()
        {
        }

        public void ClearAll()
        {
            DataSource = null;
            Columns.Clear();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
