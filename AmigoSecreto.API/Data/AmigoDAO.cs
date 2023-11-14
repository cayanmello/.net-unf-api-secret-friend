using AmigoSecreto.API.Models;
using AmigoSecreto.API.Data.Interfaces;

namespace AmigoSecreto.API.Data;

public class AmigoDAO : IAmigoDAO 
{        
    public Amigo GetById(string id)
    {
        //implementar logica para buscar um registro no arquivo com o mesmo id.
        throw new NotImplementedException();
    }
    
    public IEnumerable<Amigo> GetAll()
    {
        //implementar logica para buscar todas os registros.
        throw new NotImplementedException();
    }
    public bool Save(Amigo amigo)
    {
        //implementar logica para salvar um registro no arquivo.
        throw new NotImplementedException();
    }
}