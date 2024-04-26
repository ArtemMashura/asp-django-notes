using System.ComponentModel.DataAnnotations;

namespace asp_django_notes.Models
{
    public class Notes
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; }

    }
}
