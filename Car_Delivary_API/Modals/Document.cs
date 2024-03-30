namespace Car_Delivary_API.Modals
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Document
    {
        [Key]
        public int DocumentID { get; set; }
        [Required]
        public string DocName { get; set; }  
        [Required]
        public string DocumentType { get; set; }
        [Required]
        public string DocumentURL { get; set; }  

        public DateTime ExpiryDate { get; set; }
        public bool IsExpiry { get; set; }=false;
        public int UserID { get; set; }

        
    }

     
}
