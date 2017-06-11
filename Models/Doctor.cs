using MedicalClinic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicalClinic.Models
{
    public class Doctor : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Years of experience")]
        public int? YearsOfExperience {
                                            get
                                            {
                                                DateTime zeroTime = new DateTime(1, 1, 1);
                                                TimeSpan span = DateTime.Today - HireDate;
                                                return (zeroTime + span).Year - 1;
                                            }
                                        }

        [DisplayName("Picture")]
        public string ImageUrl { get; set; }

        public virtual ICollection<Specialization> Specializations { get; set; } //many-many relationship
        public virtual Department Department { get; set; } // 1-many relationship
    }
}