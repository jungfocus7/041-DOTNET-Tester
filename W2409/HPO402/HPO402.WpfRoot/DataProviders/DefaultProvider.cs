using HPO402.WpfRoot.Models;


namespace HPO402.WpfRoot.DataProviders
{
    public static class DefaultProvider
    {
        public const string ServerInfosDisplayMemberPath = "FullName";
        public static ServerInfoCollection ServerInfos { get; private set; }


        public const string UserInfosDisplayMemberPath = "FullName";
        public static UserInfoCollection UserInfos { get; private set; }


        public const string CaseInfosDisplayMemberPath = "FullName";
        public static CaseInfoCollection CaseInfos { get; private set; }


        public static void LoadData()
        {
            ServerInfos = new ServerInfoCollection()
            {
                new ServerInfo()
                {
                    Name = "(차세대)개발서버",
                    Url = "https://www.youtube.com/watch?v=U4",
                },
                new ServerInfo()
                {
                    Name = "(pcn)개발서버",
                    Url = "https://www.youtube.com/watch?v=U4",
                },
                new ServerInfo()
                {
                    Name = "(로컬)개발서버",
                    Url = "https://www.youtube.com/watch?v=U4",
                }
            };

            UserInfos = new UserInfoCollection()
            {
                new UserInfo()
                {
                    Court = "000200",
                    Id = "empo312",
                },
                new UserInfo()
                {
                    Court = "000200",
                    Id = "empo312",
                },
                new UserInfo()
                {
                    Court = "000200",
                    Id = "empo312",
                },
            };
            for (int i = 0; i < 99999; ++i)
            {
                UserInfos.Add(new UserInfo()
                {
                    Court = "000200",
                    Id = "empo312",
                });
            }

            CaseInfos = new CaseInfoCollection()
            {
                new CaseInfo()
                {
                    Code = "021",
                    Name = "박종명",
                },
                new CaseInfo()
                {
                    Code = "022",
                    Name = "임헌진",
                },
                new CaseInfo()
                {
                    Code = "023",
                    Name = "이중호",
                },
                new CaseInfo()
                {
                    Code = "077",
                    Name = "정희범",
                },
                new CaseInfo()
                {
                    Code = "999",
                    Name = "이병기",
                },
            };
        }
    }
}
