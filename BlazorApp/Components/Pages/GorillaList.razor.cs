using BlazorApp.Models;
using BlazorApp.Services;
using Microsoft.AspNetCore.Components;
using Radzen;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Components.Pages
{
    public partial class GorillaList
    {
        private List<BlazorApp.Models.Gorilla> gorillaList = new List<BlazorApp.Models.Gorilla>();

        protected override void OnInitialized()
        {
            LoadGorillas();
        }

        private async Task LoadGorilla(LoadDataArgs args)
        {
            await Task.Yield();
            LoadGorillas();
        }

        private void LoadGorillas()
        {
            gorillaList = GorillaService.GetGorillas()
                .OrderBy(g => g)
                .ToList();
        }

        private void NavigateToAddGorilla()
        {
            Navigation.NavigateTo("/TaskToroku");
        }
    }
}