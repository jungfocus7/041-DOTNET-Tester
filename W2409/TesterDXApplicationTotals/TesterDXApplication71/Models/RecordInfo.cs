using System.ComponentModel;


namespace TesterDXApplication71.Models
{
    /// <summary>
    /// 기록정보
    /// </summary>
    public sealed class RecordInfo
    {
        public int PNum { get; set; }
        public int Num { get; set; }
        public string BaseDate { get; set; }
        public string DocumentName { get; set; }
        public string Submitter { get; set; }
        public string ProgrssState { get; set; }
        public string StartPage { get; set; }
    }
    public sealed class RecordInfoList : BindingList<RecordInfo>
    {
    }
}
