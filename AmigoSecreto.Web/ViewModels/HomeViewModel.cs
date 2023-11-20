using AmigoSecreto.Web.Models;

namespace AmigoSecreto.Web.ViewModels
{
    public class HomeViewModel
    {
        public List<Amigo>? Amigos { get; set; } = new();
        public FeedbackModel Feedback { get; set; }

    }
    public class FeedbackModel
    {
        public Tipo Tipo { get; set; }
        public string Message { get; set; }

        public static FeedbackModel Create(Tipo tipo, string message)
            =>  new FeedbackModel
                {
                    Tipo = tipo,
                    Message = message
                };        
    }
    public enum Tipo
    {
        Error,
        Success,
        Info
    }
}
