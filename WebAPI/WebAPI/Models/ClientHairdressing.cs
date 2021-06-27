using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class ClientHairdressingDog
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string clientName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string clientLastName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string city { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string street { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string phone { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string email { get; set; }

        public DateTime clientCreationDt { get; set; }

        public List<ClientHairdressingDogOrder> ClientHairdressingDogOrder { get; set; }
    }
}
