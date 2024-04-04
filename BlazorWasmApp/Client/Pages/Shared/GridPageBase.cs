using BlazorWasmApp.Client.Services;
using BlazorWasmApp.Shared.Domain.Entities.Interfaces;
using Microsoft.AspNetCore.Components;

namespace BlazorWasmApp.Client.Pages.Shared
{
    public class GridPageBase<TEntity, THistory> : PageBase
        where TEntity : class, IEntityBase
        where THistory : class
    {
        protected List<TEntity>? Entities { get; set; }

        [Inject]
        protected IService<TEntity, THistory>? EntityService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Entities = await EntityService!.GetAll();
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
