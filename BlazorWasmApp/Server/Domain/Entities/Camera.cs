namespace BlazorWasmApp.Server.Domain.Entities
{
    public class Camera : EntityBase
    {
        public string? Serial { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
    }
}
