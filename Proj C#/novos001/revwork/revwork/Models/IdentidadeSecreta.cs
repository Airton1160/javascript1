using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revwork.Models
{
    public class IdentidadeSecreta
    {
        public int Id { get; set; }
        public int NomeReal { get; set; }
        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; }
    }
}
