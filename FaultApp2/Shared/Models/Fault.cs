using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FaultApp2.Shared.Models
{
   public class Fault 
    {

        [Required()]
        public int Id { get; set; }
        [Required()]
        public string MakinaGrubu { get; set; }
        public string Makina { get; set; }
        public string Operator { get; set; }
        [Required()]
        public DateTime RecordTime { get; set; } = DateTime.Now;
        public string Description { get; set; }
        [Required()]
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime FixedTime { get; set; } = DateTime.Now;
        public string FixDescription { get; set; }
        public string FixBy { get; set; }
        public FaultStatus Status { get; set; } = FaultStatus.REPORTED;

    }
}
