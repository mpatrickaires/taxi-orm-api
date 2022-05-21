using System.ComponentModel.DataAnnotations;

namespace TaxiOrmApi.Models
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
