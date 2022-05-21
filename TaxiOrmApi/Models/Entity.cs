using System.ComponentModel.DataAnnotations;

namespace TaxiOrmApi.Models
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
