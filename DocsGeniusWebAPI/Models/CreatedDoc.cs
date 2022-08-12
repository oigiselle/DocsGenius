using System;
using System.ComponentModel.DataAnnotations;

namespace DocsGeniusWebAPI.Models
{
    public class CreatedDoc
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public string Description { get; set; }

        public string DestinationFolderURL { get; set; }

        public int DocTemplateId { get; set; }

        public int FieldAuxId { get; set; }



    }
}
