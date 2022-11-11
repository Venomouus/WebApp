using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ClienteModel
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome da empresa")]
        public string Nm_Empresa { get; set; }
        public int Cd_Empresa { get; set; }
        public int Ds_Cnpj { get; set; }
        public int Nr_Total_Onibus { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data_Cadastro { get; set; }
    }
}