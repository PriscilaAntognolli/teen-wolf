namespace TeenWolf.Models;


    public class Personagem
    {
        // Atributos
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<string> Tipo { get; set; }
        public string Imagem { get; set; }

        // Método Construtor
        public Personagem()
        {
            Tipo = new List<string>();
        }
    }

