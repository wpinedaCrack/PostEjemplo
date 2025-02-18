namespace POS.Application.Dtos.Request
{
    public class PersonaRequestDto
    {
        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public int? Edad { get; set; }

        public string? Email { get; set; }
    }

}
