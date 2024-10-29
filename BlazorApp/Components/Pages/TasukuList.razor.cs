using BlazorApp.Models;
using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using Radzen;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Components.Pages
{
    public partial class TasukuList
    {
        private List<BlazorApp.Models.Tasuku> tasukuList = new List<BlazorApp.Models.Tasuku>();

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
    }
}