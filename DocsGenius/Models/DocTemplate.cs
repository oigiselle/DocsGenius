using System.ComponentModel.DataAnnotations;

namespace DocsGenius.Models
{
    public class DocTemplate
    {
        [Key]
        public int Id {get; set;}

        [Required]
        public string DocsTemplateURL {get; set;}

        public string Name {get; set;}

        public string Description { get; set; }

        public string Type { get; set; }


    }
}
