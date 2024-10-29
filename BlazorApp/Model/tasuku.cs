using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class Tasuku : IComparable<Tasuku>
    {
        [Required(ErrorMessage = "題名は必須です。")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "期限は必須です。")]
        public DateOnly Kigen { get; set; }

        [Required(ErrorMessage = "状態は必須です。")]
        public int Status { get; set; }
        public string Naiyo { get; set; } = string.Empty;

        public int CompareTo(Tasuku? other)
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