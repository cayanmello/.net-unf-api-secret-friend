using AmigoSecreto.API.Models;

namespace AmigoSecreto.API.Data.Interfaces;

public interface IParDAO
{
    public void GerarPares();
    public IEnumerable<Par> GetAll();
    public Par GetById(Guid id);
}
