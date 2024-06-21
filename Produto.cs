using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRABALHOAPI
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(35)]
        public string nome { get; set; }

        [Required]
        [StringLength(35)]
        public string descricao { get; set; }

        [Required]
        [StringLength(15)]
        public string categoria { get; set; }

        [Required]
        [StringLength(15)]
        public string marca { get; set; }

        [Required]
        [StringLength(35)]
        public string modelo { get; set; }

        [Required]
        public float preço { get; set; }

        public DateTime datafabricacao { get; set; }

        public DateTime datavalidade { get; set; }
    }
}
