using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain
{
    public abstract class BaseDataEntities
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity),Column("Id")]
        public int Id { get; set; } 
    }
}
