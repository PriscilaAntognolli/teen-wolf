namespace TeenWolf.Models;

    public class DetailsDto
    {
        public Personagem Prior { get; set; }
        public Personagem Current { get; set; }
        public Personagem Next { get; set; }
        public List<Tipo> Tipos { get; set; }
    }
