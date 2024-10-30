using BlazorApp.Services;
using BlazorApp.Models;
using Radzen;

namespace BlazorApp.Components.Pages
{
    public partial class TasukuList
    {
        private List<Tasuku> tasukuList = new List<Tasuku>();

        protected override void OnInitialized()
        {
            Loadtasuku();
        }

        private async Task LoadTasuku(LoadDataArgs args)
        {
            await Task.Yield();
            Loadtasuku();
        }

        private void Loadtasuku()
        {
            tasukuList = TasukuService.GetTasuku()
                .OrderBy(g => g)
                .ToList();
        }

        private void NavigateToAddTasuku()
        {
            Navigation.NavigateTo("/TasukuToroku");
        }
        private string StatusCodeToName(int statusCode)
        {
            return statusCode switch
            {
                0 => "未着手",
                1 => "仕掛中",
                2 => "完了",
                9 => "無視",
                _ => "不明"
            };
        }
    }
}