using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class tblContactInfoAccountDetails
    {
        [Key]
        public Int64 ContactInfoAccountDetailsId { get; set; }
        public string PrimaryEmail { get; set; }
        [Required]
        public string SecondaryEmail { get; set; }
        [Required]
        public string PrimaryPhone { get; set; }
        [Required]
        public string SecondaryPhone { get; set; }
        [Required]
        public string PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string FilePath { get; set; }
        public Int64? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual tblUser tblUser { get; set; }
    }
}
