using BlazorApp.Services;
using BlazorApp.Models;

namespace BlazorApp.Components.Pages
{
    public partial class ShainInfoToroku
    {
        private ShainInfo shaininfo = new ShainInfo
        {
            Nyushabi = DateOnly.FromDateTime(DateTime.Now)
        };

        private void HandleValidSubmit()
        {
            ShainInfoService.AddShainInfo(shaininfo);
            Navigation.NavigateTo("/");
        }

        private void Cancel()
        {
            Navigation.NavigateTo("/");
        }

    }
}
