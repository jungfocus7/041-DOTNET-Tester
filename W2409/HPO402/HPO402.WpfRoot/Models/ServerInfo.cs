using HPO402.Common.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace HPO402.WpfRoot.Models
{
    public sealed class ServerInfo : BaseInfo
    {
        public const string PnmName = "Name";
        public string m_name;
        public string Name
        {
            get { return m_name; }
            set
            {
                if (m_name == value) return;
                m_name = value;
                OnPropertyChanged(PnmName);
            }
        }

        public const string PnmUrl = "Url";
        public string m_url;
        public string Url
        {
            get { return m_url; }
            set
            {
                if (m_url == value) return;
                m_url = value;
                OnPropertyChanged(PnmUrl);
            }
        }

        public string FullName
        {
            get { return $"[{Name}] {Url}"; }
        }

        public override string GetSearchValue()
        {
            if (string.IsNullOrWhiteSpace(FullName))
                return base.GetSearchValue();
            else
                return FullName;
        }
    }

    public sealed class ServerInfoCollection : ObservableCollection<ServerInfo> { }
}
