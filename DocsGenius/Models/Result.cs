using System;
using System.ComponentModel.DataAnnotations;


namespace DocsGenius.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool Success { get; set; }

        public DateTime Date { get; set; }

        public CreatedDoc CreatedDoc { get; set; }
    }
}
