using BlazorWasmApp.Client.Services;
using BlazorWasmApp.Shared.Domain.Entities.Interfaces;
using Humanizer;
using Microsoft.AspNetCore.Components;

namespace BlazorWasmApp.Client.Pages.Shared
{
    public class DetailsPageBase<TEntity, THistory> : PageBase
        where TEntity : class, IEntityBase, new()
        where THistory : class
    {
        [Parameter]
        public int EntityId { get; set; }

        [Inject]
        protected IService<TEntity, THistory>? EntityService { get; set; }

        protected TEntity? Entity;
        protected IEnumerable<THistory>? EntityHistories;

        protected override async Task OnInitializedAsync()
        {
            PageDetails!.TabTitle = typeof(TEntity).Name + " Details";
            PageDetails!.PageTitle = typeof(TEntity).Name + " Details";

            if (EntityId != 0)
            {
                Entity = await EntityService!.GetById(EntityId);
                EntityHistories = await EntityService!.GetByIdTemporal(EntityId);
            }
            else
            {
                Entity = new TEntity();
            }

            IsLoading = Entity != null ? false : true;
        }

        protected async Task Save()
        {
            if (EntityId == 0)
            {
                await EntityService!.Add(Entity!);
            }
            else
            {
                await EntityService!.Update(Entity!);
            }

            NavigationManager!.NavigateTo($"/{typeof(TEntity).Name.Pluralize().ToLower()}");
        }

        protected void RedirectToGrid()
        {
            NavigationManager!.NavigateTo($"/{typeof(TEntity).Name.Pluralize().ToLower()}");
        }
    }
}
