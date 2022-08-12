using System;

namespace DocsGeniusWebAPI.Models
{
    public class DocsResult
    {
        public int Id { get; set; }

        public bool Result { get; set; }

        public int CreatedDocId { get; set; }

        public DateTime Date { get; set; }
    }
}
