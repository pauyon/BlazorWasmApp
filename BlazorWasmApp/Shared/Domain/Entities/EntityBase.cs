using BlazorWasmApp.Shared.Domain.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BlazorWasmApp.Shared.Domain.Entities
{
    public class EntityBase : IEntityBase
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }
    }
}
