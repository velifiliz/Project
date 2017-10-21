using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Domain
{
    [Table("Personal")]
    public class Personal : BaseDataEntities
    {
 

        [Column("Name")]
        public string Name { get; set; }

        [Column("Lastname")]
        public string Lastname { get; set; }
    }
}
