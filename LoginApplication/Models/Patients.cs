using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginApplication.Models
{
    public class Patients
    {
        [Key]
        public int patient_id { get; set; }
        public int user_id { get; set; }
        [Required]
        [StringLength(100)]
        public string P_First_name { get; set; }
        [StringLength(100)]
        [Required]
        public string P_Last_name { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public string P_Phone { get; set; }
        [Required]
        [MaxLength(100)]
        [EmailAddress]
        public string P_Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string P_Address { get; set; }
        [Required]
        [MaxLength(100)]
        public string Medical_condition { get; set; }
        [Required]
        public bool IsFollowUp { get; set; }
    }
}