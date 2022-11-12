using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("Cliente")]  
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome da empresa")]
        public string Nm_Empresa { get; set; }
        public int Cd_Empresa { get; set; }
        [Key]
        [StringLength(14)]
        public int Ds_Cnpj { get; set; }
        public int Nr_Total_Onibus { get; set; }

        public int Capacidade { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data_Cadastro { get; set; }
    }
}