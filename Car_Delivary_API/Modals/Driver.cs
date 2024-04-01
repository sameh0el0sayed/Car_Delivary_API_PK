using System.ComponentModel.DataAnnotations;

namespace Car_Delivary_API.Modals
{
    public class Driver
    {
        [Key]
        [StringLength(50)]
        public string DriverID { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [StringLength(50)]
        public string VehicleID { get; set; }     
        [Required]
        [StringLength(50)]
        public string UserId { get; set; }
        [Required]
        
        public int DriverLicenseNo { get; set; }
       
        public bool IsActive { get; set; }=false;
    }
}