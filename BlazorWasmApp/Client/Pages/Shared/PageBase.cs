using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorWasmApp.Client.Pages.Shared
{
    public class PageBase : ComponentBase
    {
        [Inject]
        public NavigationManager? NavigationManager { get; set; }
        
        [Inject]
        public IDialogService? DialogService { get; set; }

        [Inject]
        public ISnackbar? Snackbar { get; set; }
    }
}
