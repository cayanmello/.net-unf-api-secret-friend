using AmigoSecreto.API.Data.Interfaces;
using AmigoSecreto.API.Models;
using AmigoSecreto.API.Services.Interfaces;

namespace AmigoSecreto.API.Services;

public class AmigoService : IAmigoService
{
    private readonly IAmigoDAO _dao;
    public AmigoService(IAmigoDAO dao)
        =>  _dao = dao;
    
    public IEnumerable<Amigo> GetAll()
        => _dao.GetAll();

    public Amigo GetById(string id)
        =>  _dao.GetById(id);

    public bool Save(Amigo amigo)
        => _dao.Save(amigo);
}