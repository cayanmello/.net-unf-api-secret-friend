using AmigoSecreto.API.Models;
using AmigoSecreto.API.Data.Interfaces;
using AmigoSecreto.API.Services.Interfaces;

namespace AmigoSecreto.API.Services;

public class ParService : IParService
{
    private readonly IParDAO _dao;
    private readonly IAmigoService _amigoService;

    public ParService(IParDAO dao, IAmigoService amigoService)
    {
        _dao = dao;
        _amigoService = amigoService;
    }

    public bool GerarPares()
    {
        var paresCount = _amigoService.GetAll().Count();

        if((paresCount % 2 != 0) && (paresCount < 4))
            return false;

        _dao.GerarPares();
        return true;
    }

    public IEnumerable<Par> GetAll()
        => _dao.GetAll();    

    public Par GetById(Guid id)
        => _dao.GetById(id);
}
