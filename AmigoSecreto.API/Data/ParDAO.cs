using System.Text;
using AmigoSecreto.API.Data.Interfaces;
using AmigoSecreto.API.Models;

namespace AmigoSecreto.API.Data;

public class ParDAO : IParDAO
{
    private readonly IAmigoDAO _amigoDao;
    public ParDAO(IAmigoDAO amigoDAO)
        => _amigoDao = amigoDAO;        
    
    public void GerarPares()
    {
        var pares = new List<Par>();
        var amigos = _amigoDao
        .GetAll()
        .OrderBy(a => new Random()
            .Next())
        .ToList();

        for(int i = 0; i < amigos.Count(); i += 2) 
        {
            var amigo1 = amigos[i];
            var amigo2 = amigos[i + 1];
            var par = new Par(Guid.NewGuid(), amigo1, amigo2);
            pares.Add(par);
        }
        try 
        {
            File.WriteAllText(Configuration.GetAmigoSecretoFilePath(), string.Empty);
            var sw = new StreamWriter(Configuration.GetAmigoSecretoFilePath(), append : false, Encoding.UTF8);            
            foreach(var par in pares)
                sw.WriteLine(par.ToCsv());

            sw.Close();
        } 
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);;
        }
        
    }
    
    public IEnumerable<Par> GetAll()
    {
        var duplas = new List<Par>();  

        try
        {
            var sr = new StreamReader(Configuration.GetAmigoSecretoFilePath(), Encoding.UTF8);

            string[] linhaSplit;
            string linha;
            do
            {
                linha = sr.ReadLine();
                linhaSplit = linha.Split(",");

                var duplaId = Guid.Parse(linhaSplit[0]);

                # region [ Construção Amigo 1]
                var amigo1Split = linhaSplit[1].Split(";");

                var amigo1 = new Amigo(
                    Guid.Parse(amigo1Split[0]),
                     amigo1Split[1],
                      amigo1Split[2],
                       DateTime.Parse(amigo1Split[2]));
# endregion
                # region [ Construção Amigo 2]
                var amigo2Split = linhaSplit[1].Split(";");                
                var amigo2 = new Amigo(
                    Guid.Parse(amigo2Split[0]),
                     amigo2Split[1],
                      amigo2Split[2],
                       DateTime.Parse(amigo2Split[2]));
#endregion
                
                duplas.Add(new Par(duplaId, amigo1, amigo2));

            } while (!sr.EndOfStream);
            sr.Close();
        } catch (Exception ex)
        {
            Console.WriteLine($"\nErro ao ler aquivo.\n{ex.Message}");
        }
        return duplas;
    }

    public Par GetById(Guid id)
        => GetAll()
        .FirstOrDefault(par => par.Id == id);

}
