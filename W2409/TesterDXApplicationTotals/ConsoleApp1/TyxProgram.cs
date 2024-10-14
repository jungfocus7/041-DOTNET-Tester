using ConsoleApp1.Helpers;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public static class TyxProgram
    {
        private static void prTester31()
        {
            //UserInfo ui = new UserInfo()
            //{
            //    Num = 99,
            //    Name = "박종명",
            //    Age = "37",
            //    Job = "유통업",
            //};


            ////string pnm = "Name";
            ////double value = ui.GetValue<double>(pnm);
            ////string value = ui.GetValue<string>(pnm);
            //string num = ui.GetStr("Num");
            //string name = ui.GetStr("Name");
            //string age = ui.GetStr("Age");
            //string job = ui.GetStr("Job");



            //string cpnm = "UserInfo.Name";

            ////var t1 = AppDomain.CurrentDomain;
            ////Type tp = typeof(UserInfo);
            ////tp.Namespace
            //var x1 = AppDomain.CurrentDomain.GetAssemblies();
            //var x2 = x1[1].GetTypes();
            //var x3 = AppDomain.CurrentDomain.GetAssemblies()
            //           .SelectMany(t => t.GetTypes())
            //           .Where(t => t.IsClass && t.Namespace == "ConsoleApp1.Models");
            //var x4 = AppDomain.CurrentDomain.GetAssemblies()
            //           .Select(t => t.GetTypes());
            //var x5 = AppDomain.CurrentDomain.GetAssemblies()
            //           .SelectMany(t => t.GetTypes());

            //foreach (var xx6 in AppDomain.CurrentDomain.GetAssemblies())
            //{
            //    var xx7 = xx6.GetName();
            //    Debug.WriteLine(xx7.Name);
            //}

            //var y1 = Assembly.GetCallingAssembly();
            //var y2 = Assembly.GetEntryAssembly();
            //var y3 = Assembly.GetExecutingAssembly();

            //var z1 = y2.GetModules();


            //string cpnm = "UserInfo.Name";

            //Type[] tpa = { typeof(UserInfo) };
            //foreach (Type tp in tpa)
            //{
            //    PropertyInfo pi = ui.GetType().GetProperty(pnm, BindingFlags.Public | BindingFlags.Instance);
            //    return pi.GetValue(ui).ToString();
            //}

            //string cpnm = "UserInfo.Num";
            //string cpnm = "UserInfo.Name";
            //string cpnm = "UserInfo.Age";
            //UserInfo ui = new UserInfo()
            //{
            //    Num = 99,
            //    Name = "박종명",
            //    Age = "37",
            //    Job = "유통업",
            //};
            //object[] vgoa = { ui };
            //string muv = ModelHelper.GetMatchUpValue(cpnm, vgoa);
        }



        /// <summary>
        /// NormalTech4
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private static string[] prGetCoreVals(string val)
        {
            if (string.IsNullOrWhiteSpace(val)) return null;

            int l = val.Length - 3;
            string txt = val.Substring(2, l);

            string[] txa = txt.Split('.');
            if ((txa != null) && (txa.Length == 2))
                return txa;
            else
                return null;
        }
        private static void prTester41()
        {
            string val = "{#UserInfo.Name}";
            string[] txa = prGetCoreVals(val);
        }


        public static void Main(string[] args)
        {
            prTester41();
        }







        //private static void prXXOP(string cpnm, object[] vgoa)
        //{
        //    string[] xca = cpnm.Split('.');
        //    if (xca.Length == 2)
        //    {
        //        foreach (object vgo in vgoa)
        //        {
        //            Type tp = vgo.GetType();
        //            if (tp.Name == xca[0])
        //            {
        //                PropertyInfo pi = tp.GetProperty(xca[1], BindingFlags.Public | BindingFlags.Instance);
        //                var x1 = pi.GetValue(vgo).ToString();
        //            }
        //        }

        //        //string tfnm = $"ConsoleApp1.Models.{xca[0]}";
        //        //Type tp = Type.GetType(tfnm);
        //        //if (tp != null)
        //        //{
        //        //    PropertyInfo pi = tp.GetProperty(xca[1], BindingFlags.Public | BindingFlags.Instance);
        //        //}
        //    }
        //}

    }





}
