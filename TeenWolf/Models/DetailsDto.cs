using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeenWolf.Models
{
    public class DetailsDto
    {
    public Personagem Prior { get; set; }
    public Personagem Current { get; set; }
    public Personagem Next { get; set; }
    }
}