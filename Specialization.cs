using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MedicalClinic.Models
{
    public class Specialization
    {
        public int SpecializationId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        //[Required]
        [StringLength(550)]
        public string Description { get; set; }

        public string IconUrl { get; set; }

        public string ImageUrl { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
    }
}
