using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Entities
{
    public class tblIdentifiaction
    {
        [Key]
        public Int64 IdentifiactionId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Suffix { get; set; }
        [Required]
        public DateTime? DOB { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Ethencity { get; set; }
        [Required]
        public string GovernmentName { get; set; }
        [Required]
        public string FilePath { get; set; }
        public Int64? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual tblUser tblUser { get; set; }
    }
    public enum Gender        
    {
        Male,
        Female
    }

}
