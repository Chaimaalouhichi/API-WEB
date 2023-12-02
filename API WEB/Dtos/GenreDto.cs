using System.ComponentModel.DataAnnotations;

namespace API_WEB.Dtos
{
    public class GenreDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
