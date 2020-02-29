using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Youtube.Api.Domain.Entities
{
    public class Conteudo
    {
        public int IdVideo { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public string Url { get; set; }
        public string Thumbnail { get; set; }
        public bool NoDescription { get; set; }
        public bool NoAuthor { get; set; }
        public string ViewCount { get; set; }
    }
}
