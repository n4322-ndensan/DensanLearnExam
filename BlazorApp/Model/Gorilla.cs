using System;

namespace BlazorApp.Models
{
    public class Gorilla : IComparable<Gorilla>
    {
        public string Title { get; set; } = string.Empty;
        public DateOnly Kigen { get; set; }
        public int Status { get; set; }
        public string Naiyo { get; set; } = string.Empty;

        public int CompareTo(Gorilla? other)
        {
            if (other == null) return 1;

            // 状態で比較（未着手→無視）
            int statusComparison = Status.CompareTo(other.Status);
            if (statusComparison != 0)
            {
                return statusComparison;
            }

            // 期限で比較（期限の近いもの・超過しているものから順）
            return Kigen.CompareTo(other.Kigen);
        }
    }
}