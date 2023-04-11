using TeenWolf.Models;

namespace TeenWolf.Services;


    public interface IWolfService
    {
        
        List<Personagem> GetPersonagens();
        List<Tipo> GetTipos();
        Personagem GetPersonagem(int numero);
        TeenWolfDto GetTeenWolfDto();
        DetailsDto GetDetailedTeenWolf(int numero);
        Tipo GetTipo(string nome);
    }

