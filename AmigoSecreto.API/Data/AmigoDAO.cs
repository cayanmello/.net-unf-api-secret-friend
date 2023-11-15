using AmigoSecreto.API.Models;
using AmigoSecreto.API.Data.Interfaces;
using System.Text;

namespace AmigoSecreto.API.Data;

public class AmigoDAO : IAmigoDAO 
{        
    public Amigo? GetById(string id)
        => GetAll().Where(amg => amg.Id?.ToString().ToUpper() == id.ToUpper()).FirstOrDefault();

    public IEnumerable<Amigo> GetAll()
    {
        var amigos = new List<Amigo>();  

        try
        {
            StreamReader sr = new StreamReader(Configuration.GetAmigoFilePath(), Encoding.UTF8);
            string[] linhaSplit;
            string linha;
            do
            {
                linha = sr.ReadLine();
                linhaSplit = linha.Split(";");
                amigos.Add(
                    new Amigo(
                        Guid.Parse(linhaSplit[0]),
                        linhaSplit[1],
                        linhaSplit[2],
                        DateTime.Parse(linhaSplit[3])
                        )
                    );
            } while (!sr.EndOfStream);
            sr.Close();
        } catch (Exception ex)
        {
            Console.WriteLine($"\nErro ao ler aquivo.\n{ex.Message}");
        }
        return amigos;
    }
    
    public bool Save(Amigo amigo)
    {
        try
        {
            var sw = new StreamWriter(Configuration.GetAmigoFilePath(), append : true);
            sw.WriteLine(amigo.ToCsv());
            sw.Close();
            return true;
        } catch(Exception ex)
        {
            Console.WriteLine("ADSP2 - Erro ao salvar registro.");
            return false;
        }
    }
}