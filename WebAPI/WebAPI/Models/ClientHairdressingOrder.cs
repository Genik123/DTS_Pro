using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class ClientHairdressingDogOrder
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName = "int")]
        public int clientId { get; set; }
        public DateTime orderDt { get; set; }
        //public  ClientHairdressingDog ClientHairdressing { get; set; }
    }
}
