using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirs.Models
{
    public class Prescription_Medicament
    {
        public int Dose { get; set; }

        [MaxLength(100)]
        public string Details { get; set; }

        [ForeignKey("Medicament")]
        public int IdMedicament { get; set; }
        public Medicament Medicament { get; set; }

        [ForeignKey("Prescription")]
        public int IdPrescription { get; set; }
        public Prescription Prescription { get; set; }


    }
}
