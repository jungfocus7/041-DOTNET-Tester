using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace HPO402.Common.Models
{
    public class BaseInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string pnm = null)
        {
            if (string.IsNullOrWhiteSpace(pnm)) return;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pnm));
        }

        public virtual string GetSearchValue()
        {
            return string.Empty;
        }
    }
}
