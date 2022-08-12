using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DocsGeniusWebAPI.Models
{
    public class Field
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FieldKey { get; set; }

        public string FieldContent { get; set; }

        public int DocTemplateId { get; set; }

        public int DocType { get; set; }

      

        
    }
}
