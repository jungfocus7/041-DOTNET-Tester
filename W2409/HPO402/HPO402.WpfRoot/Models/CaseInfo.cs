using HPO402.Common.Models;
using System.Collections.ObjectModel;


namespace HPO402.WpfRoot.Models
{
    public sealed class CaseInfo : BaseInfo
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string FullName
        {
            get { return $"({Code}){Name}"; }
        }

        public override string GetSearchValue()
        {
            if (string.IsNullOrWhiteSpace(FullName))
                return base.GetSearchValue();
            else
                return FullName;
        }
    }

    public sealed class CaseInfoCollection : ObservableCollection<CaseInfo>
    {
    }
}
