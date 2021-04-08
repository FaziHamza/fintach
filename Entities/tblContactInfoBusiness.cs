using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class tblContactInfoBusiness
    {
        [Key]
        public Int64 ContactInfoBusinessId { get; set; }
        [Required]
        public string PrimaryEmail { get; set; }
        [Required]
        public string SecondaryEmail { get; set; }
        [Required]
        public string PrimaryPhone { get; set; }
        [Required]
        public string SecondaryPhone { get; set; }
        [Required]
        public bool SaveASAccountDetails { get; set; }
        public Int64? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual tblUser tblUser { get; set; }
    }
}
