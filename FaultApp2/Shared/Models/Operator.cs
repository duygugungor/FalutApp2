using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FaultApp2.Shared.Models
{
    public class Operator
    {
        [Required()]
        public int Id { get; set; }
        [Required()]
        public string NameSurname { get; set; }

//TODO: add role enum        
}
}
