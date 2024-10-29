using BlazorApp.Models;

namespace BlazorApp.Services
{
    public static class TasukuService
    {
        private static List<Tasuku> tasuku = new List<Tasuku>
        {
            new Tasuku { Title = "タスク1", Kigen = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), Status = 0, Naiyo = "タスク1の内容" },
            new Tasuku { Title = "タスク2", Kigen = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), Status = 1, Naiyo = "タスク2の内容" },
            new Tasuku { Title = "タスク3", Kigen = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), Status = 2, Naiyo = "タスク3の内容" }
        };

        public static void AddTasuku(Tasuku tasukulist)
        {
            tasuku.Add(tasukulist);
        }

        public static List<Tasuku> GetTasuku()
        {
            return tasuku;
        }
    }
}