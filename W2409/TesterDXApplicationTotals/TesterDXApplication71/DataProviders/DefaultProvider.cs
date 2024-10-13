using TesterDXApplication71.Models;

namespace TesterDXApplication71.DataProviders
{
    public static class DefaultProvider
    {
        public static readonly RecordInfoList RecordInfos = new RecordInfoList();

        public static void LoadData()
        {
            for (int i = 0; i < 3000000; ++i)
            {
                RecordInfo rci = new RecordInfo()
                {
                    PNum = 0,
                    Num = i + 1,
                    BaseDate = "24.03.08",
                    DocumentName = "검사 증거목록",
                    Submitter = "210관리자",
                    ProgrssState = "완료",
                    StartPage = "1",
                };
                RecordInfos.Add(rci);
            }

            int j = 0;
            foreach (RecordInfo rci in RecordInfos)
            {
                if ((j >= 30) && (j <= 34))
                {
                    rci.PNum = 30;
                }
                ++j;
            }


            //for (int i = 300; i <= 10000; ++i)
            //{
            //    RecordInfo rci = new RecordInfo()
            //    {
            //        PNum = 0,
            //        Num = i + 1,
            //        BaseDate = "24.03.08",
            //        DocumentName = "검사 증거목록",
            //        Submitter = "210관리자",
            //        ProgrssState = "완료",
            //        StartPage = "1",
            //    };
            //    RecordInfos.Add(rci);
            //}
        }
    }
}
