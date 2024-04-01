namespace Car_Delivary_API.Modals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Document
    {
        [Key]
        [MaxLength(50)]
        public string DocumentID { get; set; } = Guid.NewGuid().ToString();
        [Required]
        [StringLength(50)]
        public string UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string DocName { get; set; }  
        [Required]
        [StringLength(20)]
        public string DocumentType { get; set; }
        [Required]
        [StringLength(50)]
        public string DocumentURL { get; set; }  

        public DateTime ExpiryDate { get; set; }
        public bool IsExpiry { get; set; }=false;
  

        
    }

     
}
