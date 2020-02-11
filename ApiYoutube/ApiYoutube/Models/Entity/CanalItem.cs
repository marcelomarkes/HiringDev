using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiYoutube.Models.Entity
{
    public class CanalItem
    {
        public int IdCanalItem { get; set; }
        public string NomeCanalItem { get; set; }
        [ForeignKey("IdCanal")]
        public virtual Canal Canal { get; set; }
        public string ComentarioCanalItem { get; set; }
    }
}
