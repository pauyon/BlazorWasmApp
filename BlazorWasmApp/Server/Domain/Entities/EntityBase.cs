using System.ComponentModel.DataAnnotations;

namespace BlazorWasmApp.Server.Domain.Entities
{
    public class EntityBase
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
