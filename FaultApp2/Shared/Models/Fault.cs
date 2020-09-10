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
        [Required()]
        public Makina Makina { get; set; } = new Makina();
        [Required()]
        public Operator Operator { get; set; } = new Operator();
        [Required()]
        public DateTime RecordTime { get; set; } = DateTime.Now;
        [Required()]
        public string Description { get; set; }

        [Required()]
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public DateTime FixedTime { get; set; } = DateTime.Now;
        public string FixDescription { get; set; }
        public Operator FixBy { get; set; } = new Operator();
        public FaultStatus Status { get; set; } = FaultStatus.REPORTED;

    }
    public class Makina
    {
        public Makina()
        {
        }

        public Makina(int id, string name, MakinaGrubu makinaGrubu)
        {
            Id = id;
            Name = name;
            MakinaGrubu = makinaGrubu;
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

        public MakinaGrubu(int id, string name)
        {
            Id = id;
            Name = name;
        }

        [Required()]
        public int Id { get; set; }
        [Required()]
        public string Name { get; set; }
    }
}

