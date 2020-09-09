using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FaultApp2.Shared.Models
{
    public class Fault 
    {

        [Required()]
        public int Id { get; set; }
        [Required()]
        public MakinaGrubu MakinaGrubu { get; set; } = new MakinaGrubu();
        public Makina Makina { get; set; } = new Makina();
        public Operator Operator { get; set; } = new Operator();
        [Required()]
        public DateTime RecordTime { get; set; } = DateTime.Now;
        public string Description { get; set; }
        [Required()]
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime FixedTime { get; set; } = DateTime.Now;
        public string FixDescription { get; set; }
        public Operator FixBy { get; set; } = new Operator();
        public FaultStatus Status { get; set; } = FaultStatus.REPORTED;

    }
   // [TypeConverter(typeof(Makina))]
    public class Makina
    {
        public Makina()
        {
        }

        [Required()]

        public int Id { get; set; }
        [Required()]
        public string Name { get; set; }
        [Required()]
        public MakinaGrubu MakinaGrubu { get; set; }
    }
   
    public class MakinaGrubu
    {
        public MakinaGrubu()
        {
        }
        [Required()]
        public int Id { get; set; }
        [Required()]
        public string Name { get; set; }
    }
}

