using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class tblUser
    {
        [Key]
        public Int64 UserId { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me?")]
        [NotMapped]
        public bool RememberMe { get; set; }
        public virtual tblResidence tblResidence { get; set; }
        public virtual tblLegalInfo tblLegalInfo { get; set; }
        public virtual tblIdentifiaction tblIdentifiaction { get; set; }
        public virtual tblContactInfoBusiness tblContactInfoBusiness { get; set; }
        public virtual tblContactInfoAccountDetails tblContactInfoAccountDetails { get; set; }
        public virtual tblSecure tblSecure { get; set; }
    }
}
