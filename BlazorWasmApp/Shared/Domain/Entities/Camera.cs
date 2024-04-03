namespace BlazorWasmApp.Shared.Domain.Entities
{
    public class Camera : EntityBase
    {
        public string? Serial { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
    }
}
