using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorWasmApp.Client.Pages.Shared
{
    public class PageBase : ComponentBase
    {
        protected virtual string? TabTitle { get; set; }
        protected virtual string? PageTitle { get; set; }

        [Inject]
        protected NavigationManager? NavigationManager { get; set; }
        
        [Inject]
        protected IDialogService? DialogService { get; set; }

        [Inject]
        protected ISnackbar? Snackbar { get; set; }
    }
}
