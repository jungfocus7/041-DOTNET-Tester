using System;
using System.Reflection;


namespace ConsoleApp1.Models
{
    public sealed class UserInfo
    {
        public int Num { get; set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string Job { get; set; }
    }

    public static class UserInfoExtension
    {
        //public T GetValue<T>(string pnm)
        //{
        //    T rv = default;

        //    Type tp = GetType();
        //    PropertyInfo[] pia = tp.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        //    foreach (PropertyInfo pi in pia)
        //    {
        //        if (pi.Name == pnm)
        //        {
        //            object vo = pi.GetValue(this);
        //            rv = (T)Convert.ChangeType(vo, typeof(T));
        //            break;
        //        }
        //    }

        //    return rv;
        //}

        public static T GetValue<T>(this UserInfo ui, string pnm)
        {
            PropertyInfo pi = ui.GetType().GetProperty(pnm, BindingFlags.Public | BindingFlags.Instance);
            return (T)Convert.ChangeType(pi.GetValue(ui), typeof(T));
            //return (T)pi.GetValue(this);
        }

        public static string GetStr(this UserInfo ui, string pnm)
        {
            PropertyInfo pi = ui.GetType().GetProperty(pnm, BindingFlags.Public | BindingFlags.Instance);
            return pi.GetValue(ui).ToString();
        }
    }
}
