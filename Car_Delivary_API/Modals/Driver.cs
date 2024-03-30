using System.ComponentModel.DataAnnotations;

namespace Car_Delivary_API.Modals
{
    public class Driver
    {
        [Key]
        public int DriverID { get; set; }
        [Required]
        public int CurrentCarID { get; set; }
        [Required]
        public int DriverLicenseNo { get; set; }
       
        public bool IsActive { get; set; }=false;
    }
}