namespace AmigoSecreto.API.Models
{
    public class Amigo
    {
        public Guid? Id { get; private set; }
        public string? Name { get; private set; }
        public string? Email { get; private set; }
        public DateTime? RegistradoEm { get; private set; }

        /// <summary>
        /// Construtor usado para criar um nove objeto
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        public Amigo(string name, string email)
        {
            Id = Guid.NewGuid();
            RegistradoEm = DateTime.Now;
            Name = name;
            Email = email;
        }

        /// <summary>
        /// Construtor usado para criar um nove objeto
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="registradoEm"></param>
        public Amigo(Guid id, string name, string email, DateTime registradoEm)
        {
            Id = id;
            Name = name;
            Email = email;
            RegistradoEm = registradoEm;
        }

    }
}
