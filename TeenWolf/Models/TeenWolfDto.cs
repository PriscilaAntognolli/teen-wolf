using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeenWolf.Models
{
    public class TeenWolfDto
    {
        public List<Tipo> Tipos { get; set; }
        public List<Personagem> Personagens { get; set; }
    }
}