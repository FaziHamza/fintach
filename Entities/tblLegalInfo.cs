using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class tblLegalInfo
    {
        [Key]
        public Int64 LegalInfoId { get; set; }
        [Required]
        public string BusinessLogo { get; set; }
        [Required]
        public string LegalBusinessName { get; set; }
        [Required]
        public string FilePath1 { get; set; }
        [Required]
        public string FilePath2 { get; set; }
        [Required]
        public string FilePath3 { get; set; }
        [Required]
        public string LegalStructure { get; set; }
        [Required]
        public string LicenseNumber { get; set; }
        [Required]
        public string OwnershipType { get; set; }
        [Required]
        public string Industry { get; set; }
        [Required]
        public DateTime? DateEstablished { get; set; }
        [Required]
        public double AnnaulRvenue { get; set; }
        [Required]
        public string EstimentalWorth { get; set; }
        [Required]
        public string BusinessSpendPerMonth { get; set; }
        [Required]
        public double LargestEstimentPurchase { get; set; }
        [Required]
        public double EstimentEcommercePrice { get; set; }
        [Required]
        public double LargestPeriodWithoutRevenue { get; set; }
        [Required]
        public string FilePath { get; set; }
        public Int64? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual tblUser tblUser { get; set; }
    }
}
