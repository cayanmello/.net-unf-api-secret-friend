using AmigoSecreto.API.Models;

namespace AmigoSecreto.API.Data.Interfaces;

public interface IAmigoDAO {
    public IEnumerable<Amigo>GetAll();
    public Amigo GetById(string id);
    public bool Save(Amigo amigo);
}