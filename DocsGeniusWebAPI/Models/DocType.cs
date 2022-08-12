using System.ComponentModel.DataAnnotations;

namespace DocsGeniusWebAPI.Models
{
    public class DocType
    {
        [Required]
        public int Id { get; set; }

        public string  Name { get; set; }

        public string Description { get; set; }

        public int DocTemplateId { get; set; }

    }
}
