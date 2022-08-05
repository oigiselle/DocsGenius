using System;
using System.ComponentModel.DataAnnotations;
using DocsGenius.Models;

namespace DocsGenius.Models
{
    public class Field
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FieldKey { get; set; }

        public string FieldContent { get; set; }

        public  DateTime DataInserted { get; set; }

        [Required]
        public DocsTemplate DocsTemplate { get; set; }

        public CreatedDoc CreatedDoc { get; set; }



    }
}
