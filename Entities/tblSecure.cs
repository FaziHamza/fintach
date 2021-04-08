using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class tblSecure
    {
        [Key]
        public Int64 SecureId { get; set; }
        [Required]
        public string SecurityQuestion1 { get; set; }
        [Required]
        public string Answer1 { get; set; }
        [Required]
        public string SecurityQuestion2 { get; set; }
        [Required]
        public string Answer2 { get; set; }
        public Int64? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual tblUser tblUser { get; set; }

    }
}
