using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Entities.DTOs
{
    public class CategoryDto : DtoGetBase
    {
        public Category Category { get; set; }
    }
}
