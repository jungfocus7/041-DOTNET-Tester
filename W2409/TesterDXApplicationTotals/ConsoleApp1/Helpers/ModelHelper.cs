using System;
using System.Reflection;


namespace ConsoleApp1.Helpers
{
    public static class ModelHelper
    {
        public static string GetMatchUpValue(string cpnm, object[] vgoa)
        {
            string rts = null;

            string[] xca = cpnm.Split('.');
            if (xca.Length == 2)
            {
                foreach (object vgo in vgoa)
                {
                    Type tp = vgo.GetType();
                    if (tp.Name == xca[0])
                    {
                        PropertyInfo pi = tp.GetProperty(xca[1], BindingFlags.Public | BindingFlags.Instance);
                        if (pi != null)
                        {
                            rts = pi.GetValue(vgo).ToString();
                            break;
                        }
                    }
                }
            }

            return rts;
        }
    }
}
