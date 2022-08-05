using System;
using System.ComponentModel.DataAnnotations;


namespace DocsGenius.Models
{
    public class CreatedDoc
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
     
        public DateTime CreatedDate { get; set; }

        public string Description { get; set; }

    }
}
