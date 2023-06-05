using System.ComponentModel.DataAnnotations;

namespace FirstWebAPI.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Please Enter Your Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter Your Description")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set;} = DateTime.Now;
    }
}
