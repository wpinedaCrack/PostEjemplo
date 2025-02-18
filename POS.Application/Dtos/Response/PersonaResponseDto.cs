namespace POS.Application.Dtos.Response
{
    public class PersonaResponseDto
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public int? Edad { get; set; }

        public string? Email { get; set; }
    }

}
