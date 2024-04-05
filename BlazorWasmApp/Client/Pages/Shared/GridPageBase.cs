using BlazorWasmApp.Client.Services;
using BlazorWasmApp.Shared.Domain.Entities.Interfaces;
using Humanizer;
using Microsoft.AspNetCore.Components;

namespace BlazorWasmApp.Client.Pages.Shared
{
    public class GridPageBase<TEntity> : PageBase
        where TEntity : class, IEntityBase, new()
    {
        protected List<TEntity>? Entities { get; set; }

        [Inject]
        protected IService<TEntity>? EntityService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            PageDetails!.TabTitle = typeof(TEntity).Name.Pluralize();
            PageDetails!.PageTitle = typeof(TEntity).Name.Pluralize();
            Entities = await EntityService!.GetAll();

            IsLoading = Entities != null ? false : true;
        }

        protected virtual void AddEditRecord(TEntity? entity)
        {
            if (entity == null)
            {
                NavigationManager!.NavigateTo($"/{typeof(TEntity).Name.ToLower()}/0");
            }
            else
            {
                NavigationManager!.NavigateTo($"/{typeof(TEntity).Name.ToLower()}/{entity.Id}");
            }

        }

        protected virtual async Task DeleteRecord(TEntity entity)
        {
        }
    }
}
