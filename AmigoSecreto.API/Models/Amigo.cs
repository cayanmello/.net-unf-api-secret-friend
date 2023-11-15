namespace AmigoSecreto.API.Models
{
    public class Amigo
    {
        public Guid? Id { get; private set; }
        public string? Name { get; private set; }
        public string? Email { get; private set; }
        public DateTime? RegistradoEm { get; private set; }


        public Amigo(string name, string email)
        {
            Id = Guid.NewGuid();
            RegistradoEm = DateTime.UtcNow;
            Name = name;
            Email = email;
        }

        public Amigo(Guid id, string name, string email, DateTime registradoEm)
        {
            Id = id;
            Name = name;
            Email = email;
            RegistradoEm = registradoEm;
        }

        public string ToCsv()
            => $"{Id};{Name};{Email};{RegistradoEm};";
        
    }
}
