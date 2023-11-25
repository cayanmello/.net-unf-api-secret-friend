using AmigoSecreto.API.Models;

namespace AmigoSecreto.API.Services.Interfaces;

public interface IAmigoService
{
    public bool Save(Amigo amigo);
    public IEnumerable<Amigo> GetAll();
    public Amigo GetById(string id);
    public bool Delete(Guid id);
    public bool Update(Amigo amigoIn);
}