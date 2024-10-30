using BlazorApp.Services;
using BlazorApp.Models;

namespace BlazorApp.Components.Pages
{
    public partial class TasukuToroku
    {
        private Tasuku tasuku = new Tasuku
        {
            Kigen = DateOnly.FromDateTime(DateTime.Now)
        };

        private void HandleValidSubmit()
        {
            TasukuService.AddTasuku(tasuku);
            Navigation.NavigateTo("/");
        }

        private void Cancel()
        {
            Navigation.NavigateTo("/");
        }

    }
}
