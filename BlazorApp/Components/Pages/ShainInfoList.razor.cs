using BlazorApp.Services;
using BlazorApp.Models;
using Radzen;

namespace BlazorApp.Components.Pages
{
    public partial class ShainInfoList
    {
        private List<ShainInfo> shaininfoList = new List<ShainInfo>();

        protected override void OnInitialized()
        {
            Loadshaininfo();
        }

        private async Task LoadShainInfo(LoadDataArgs args)
        {
            await Task.Yield();
            Loadshaininfo();
        }

        private void Loadshaininfo()
        {
            shaininfoList = ShainInfoService.GetShainInfo()
                .OrderBy(g => g)
                .ToList();
        }

        private void NavigateToAddShainInfo()
        {
            Navigation.NavigateTo("/ShainInfoToroku");
        }
        private string StatusCodeToName(int statusCode)
        {
            return statusCode switch
            {
                0 => "正社員",
                1 => "嘱託",
                3 => "協力会社",
                _ => "不明"
            };
        }
    }
}