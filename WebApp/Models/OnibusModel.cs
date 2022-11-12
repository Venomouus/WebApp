using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Onibus")]
    public class OnibusModel
    {
        public int Id { get; set; }
        [StringLength(7)]
        [Required]
        public string Placa { get; set; }
        
        public int NumRota { get; set; }

        [StringLength(160)] 
        public string NomRota { get; set;}
        [Range(0, 200)]
        public int NumEntradas { get; set; }
        [Range(0,200)]
        public int NumSaida { get; set; }

        [ForeignKey("Cd_Empresa")]
        public string Cd_Empresa { get; set; }
        [ForeignKey("Nm_Empresa")]
        public string Nm_Empresa { get; set; }

    }
}
