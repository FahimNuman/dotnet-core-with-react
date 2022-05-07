using System.ComponentModel.DataAnnotations;

namespace DotNet6Api.Models
{
    public class Post
    {
       public int Id { get; set; }
        [Required(ErrorMessage ="Plz put some data")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Plz put some data")]
        public string Description { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
