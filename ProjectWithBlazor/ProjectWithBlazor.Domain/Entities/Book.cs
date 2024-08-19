
using System.ComponentModel.DataAnnotations;

namespace ProjectWithBlazor.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Type A Title!")]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Please Type An Author'Name!")]
        [StringLength(100)]
        public string? Author { get; set; }
        public DateTime? PublicationDate { get; set; }

        [EnumDataType(typeof(Category),ErrorMessage = "Please Select A Category!")]
        public Category Category { get; set; }
    }
}
