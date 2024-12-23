using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class ShainInfo : IComparable<ShainInfo>
    {
        [Required(ErrorMessage = "氏名は必須です。")]
        public string ShainName { get; set; } = string.Empty;

        [Required(ErrorMessage = "入社日は必須です。")]
        public DateOnly Nyushabi { get; set; }

        [Required(ErrorMessage = "雇用形態は必須です。")]
        public int Status { get; set; }
        public string Biko { get; set; } = string.Empty;
        public string BikoFirstLine
        {
            get
            {
                if (string.IsNullOrEmpty(Biko))
                {
                    return string.Empty;
                }
                var lines = Biko.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                return lines.Length > 0 ? lines[0] : string.Empty;
            }
        }
        public int CompareTo(ShainInfo? other)
        {
            if (other == null) return 1;

            // 状態で比較（正社員、嘱託、協力会社）
            int statusComparison = Status.CompareTo(other.Status);
            if (statusComparison != 0)
            {
                return statusComparison;
            }

            // 期限で比較（期限の近いもの・超過しているものから順）
            return Nyushabi.CompareTo(other.Nyushabi);
        }
    }
}