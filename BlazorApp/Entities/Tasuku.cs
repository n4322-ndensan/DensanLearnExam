namespace BlazorApp.Entities;

public class Tasuku(string title, DateOnly kigen, int status, string naiyo)
{
    public string Title { get; } = title;
    public DateOnly Kigen { get; } = kigen;
    public int Status { get; } = status;
    public string Naiyo { get; } = naiyo;
}