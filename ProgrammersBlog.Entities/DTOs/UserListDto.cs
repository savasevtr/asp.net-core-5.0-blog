using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Entities.Abstract;
using System.Collections.Generic;

namespace ProgrammersBlog.Entities.DTOs
{
    public class UserListDto : DtoGetBase
    {
        public IList<User> Users { get; set; }
    }
}
