using HPO402.Common.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace HPO402.WpfRoot.Models
{
    public sealed class UserInfo : BaseInfo
    {
        public const string PnmCourt = "Court";
        public string m_court;
        public string Court
        {
            get { return m_court; }
            set
            {
                if (m_court == value) return;
                m_court = value;
                OnPropertyChanged(PnmCourt);
            }
        }

        public const string PnmId = "Id";
        public string m_id;
        public string Id
        {
            get { return m_id; }
            set
            {
                if (m_id == value) return;
                m_id = value;
                OnPropertyChanged(PnmId);
            }
        }

        public string FullName
        {
            get { return $"[{Court}] {Id}"; }
        }

        public override string GetSearchValue()
        {
            if (string.IsNullOrWhiteSpace(FullName))
                return base.GetSearchValue();
            else
                return FullName;
        }
    }

    public sealed class UserInfoCollection : ObservableCollection<UserInfo> { }
}
