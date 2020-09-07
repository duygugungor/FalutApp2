using System;
using System.ComponentModel.DataAnnotations;

namespace FaultApp2.Shared.Models
{
    public class Fault 
    {

        [Required()]
        public int Id { get; set; }
        [Required()]
        public MakinaGrubu MakinaGrubu { get; set; }
        public Makina Makina { get; set; }
        public Operator Operator { get; set; }
        [Required()]
        public DateTime RecordTime { get; set; } = DateTime.Now;
        public string Description { get; set; }
        [Required()]
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime FixedTime { get; set; } = DateTime.Now;
        public string FixDescription { get; set; }
        public Operator FixBy { get; set; }
        public FaultStatus Status { get; set; } = FaultStatus.REPORTED;

    }

    public class Makina
    {
        [Required()]

        public int Id { get; set; }
        [Required()]
        public string Name { get; set; }
        [Required()]
        public MakinaGrubu MakinaGrubu { get; set; }
    }

    public class MakinaGrubu
    {
        [Required()]

        public int Id { get; set; }
        [Required()]
        public string Name { get; set; }
    }
}

