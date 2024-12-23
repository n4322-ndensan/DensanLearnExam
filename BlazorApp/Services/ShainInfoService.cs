using BlazorApp.Models;

namespace BlazorApp.Services
{
    public static class ShainInfoService
    {
        private static List<ShainInfo> shaininfo = new List<ShainInfo>
        {
            new ShainInfo { ShainName = "電算一郎", Nyushabi = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), Status = 0, Biko = "基本情報技術者" },
            new ShainInfo { ShainName = "電算次郎", Nyushabi = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), Status = 1, Biko = "応用情報技術者" },
            new ShainInfo { ShainName = "電算三郎", Nyushabi = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), Status = 3, Biko = "基本情報技術者" },
            new ShainInfo { ShainName = "電算四郎", Nyushabi = DateOnly.FromDateTime(DateTime.Now.AddDays(4)), Status = 0, Biko = "応用情報技術者" },
            new ShainInfo { ShainName = "電算五郎", Nyushabi = DateOnly.FromDateTime(DateTime.Now.AddDays(5)), Status = 1, Biko = "基本情報技術者" }
        };

        public static void AddShainInfo(ShainInfo shaininfolist)
        {
            shaininfo.Add(shaininfolist);
        }

        public static List<ShainInfo> GetShainInfo()
        {
            return shaininfo;
        }
    }
}