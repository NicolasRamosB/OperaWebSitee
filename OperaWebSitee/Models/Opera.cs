using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OperaWebSitee.Validations;

namespace OperaWebSite.Models
{
    public class Opera
    {
        public int OperaId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//view/ef
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]//view
        public string Title { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]//view/ef
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]//view
        public string Composer { get; set; }

        [CheckValidYear]
        public int Year { get; set; }
    }
}

