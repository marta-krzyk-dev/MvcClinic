using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MedicalClinic.Models;

namespace MedicalClinic.Models
{
    public class Department
    {
        public int ID { get; set; }

        public Address Address { get; set; }

        [RegularExpression(@"/\(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})/",
    ErrorMessage = "Phone number is is not valid.")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

    virtual public ICollection<Employee> Employees { get; set; }
    }
}