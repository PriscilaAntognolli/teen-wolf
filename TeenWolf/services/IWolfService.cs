using TeenWolf.Models;
namespace TeenWolf.Services;


    
    public interface IWolfService
    {
        List<Personagem> GetPersonagens();
        List<Tipo> GetTipos();
        Personagem GetPersonagem(int Numero);
        TeenWolfDto GetTeenWolfDto();
        DetailsDto GetDetailedPersonagem(int Numero);
        Tipo GetTipo(string Nome);
    }
