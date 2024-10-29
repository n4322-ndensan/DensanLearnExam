using BlazorApp.Services;

namespace BlazorApp.Components.Pages
{
    public partial class TasukuToroku
    {
        private BlazorApp.Models.Tasuku tasuku = new BlazorApp.Models.Tasuku
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
