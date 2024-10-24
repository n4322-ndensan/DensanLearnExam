using BlazorApp.Models;

namespace BlazorApp.Services
{
    public static class GorillaService
    {
        private static List<Gorilla> gorillas = new List<Gorilla>
        {
            new Gorilla { Title = "タスク1", Kigen = DateOnly.FromDateTime(DateTime.Now.AddDays(1)), Status = 0, Naiyo = "タスク1の内容" },
            new Gorilla { Title = "タスク2", Kigen = DateOnly.FromDateTime(DateTime.Now.AddDays(2)), Status = 1, Naiyo = "タスク2の内容" },
            new Gorilla { Title = "タスク3", Kigen = DateOnly.FromDateTime(DateTime.Now.AddDays(3)), Status = 2, Naiyo = "タスク3の内容" }
        };

        public static void AddGorilla(Gorilla gorilla)
        {
            gorillas.Add(gorilla);
        }

        public static List<Gorilla> GetGorillas()
        {
            return gorillas;
        }
    }
}