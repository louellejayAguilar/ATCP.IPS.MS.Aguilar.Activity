using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCP.IPS.MS.Aguilar.Model.Dto
{
    public class CustomerDto
    {
        public int CustomerID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be atleast {2} characters long.", MinimumLength = 2)]
        public string firstName { get; set; }
        public string middleName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be atleast {2} characters long.", MinimumLength = 2)]
        public string lastName { get; set; }

        [Required]
        public string Address { get; set; }
        [Required]
        [Range(18,65, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Age { get; set; }
        public string Gender { get; set; }

        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDttm { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDttm { get; set;}
        public bool IsActive { get; set; }
    }
}
