namespace BlazorWasmApp.Shared.Domain.Entities.Interfaces
{
    public interface IEntityBase
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
