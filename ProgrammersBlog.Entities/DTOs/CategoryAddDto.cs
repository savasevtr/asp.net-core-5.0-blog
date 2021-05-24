using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProgrammersBlog.Entities.DTOs
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır.")]
        public string Name { get; set; }

        [DisplayName("Açıklama")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır.")]
        public string Description { get; set; }

        [DisplayName("Not")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden fazla olmamalıdır.")]
        public string Note { get; set; }

        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir")]
        public bool IsActive { get; set; }
    }
}
