using AmigoSecreto.API.Models;
using AmigoSecreto.API.Services.Interfaces;

namespace AmigoSecreto.API.Services;

public class AmigoService : IAmigoService
{
    public IEnumerable<Amigo> GetAll()
    {
        // Implementar logica para buscar todos os registros usando as classes de serviço DAO.
        throw new NotImplementedException();
    }

    public Amigo GetById(string id)
    {
        // Implementar logica para buscar um registro usando as classes de serviço DAO.
        throw new NotImplementedException();
    }

    public Amigo Save(Amigo amigo)
    {
        // Implementar logica para salvar um registro usando as classes de serviço DAO.
        throw new NotImplementedException();
    }
}