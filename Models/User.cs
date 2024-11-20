namespace MyMvcApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Inicializar con un valor no nulo
        public string Email { get; set; } = string.Empty; // Inicializar con un valor no nulo
    }
}
