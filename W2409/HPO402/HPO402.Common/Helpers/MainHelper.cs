using System.Windows.Controls;

namespace HPO402.Common.Helpers
{
    public static class MainHelper
    {
        public static UserControl RootContainer { get; private set; }

        public static void InitOnce(UserControl rootCont)
        {
            if (RootContainer == null)
            {
                RootContainer = rootCont;
            }
        }
    }
}
