using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public static class TyxProgram
    {
        public static void Main(string[] args)
        {
            UserInfo ui = new UserInfo()
            {
                Num = 99,
                Name = "박종명",
                Age = "37",
                Job = "유통업",
            };

            string pnm = "Num";
            double value = ui.GetValue<double>(pnm);
        }
    }



    public sealed class UserInfo
    {
        public T GetValue<T>(string pnm)
        {
            T rv = default;

            Type tp = GetType();
            PropertyInfo[] pia = tp.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            if ((pia != null) && (pia.Length > 0))
            {
                foreach (PropertyInfo pi in pia)
                {
                    if (pi.Name == pnm)
                    {
                        object vo = pi.GetValue(this);
                        rv = (T)Convert.ChangeType(vo, typeof(T));
                        break;
                    }
                }
            }


            return rv;
        }

        public int Num { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string Job { get; set; }
    }

}
