using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class tblResidence
    {
        [Key]
        public Int64 ResidenceId { get; set; }
        [Required]
        public string CitzenshipCountry { get; set; }
        [Required]
        public string ResidingCountry { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string SuitApt { get; set; }
        [Required]
        public string StateProvince { get; set; }
        [Required]
        public string City { get; set; }
        public Int64? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual tblUser tblUser { get; set; }
    }
}
