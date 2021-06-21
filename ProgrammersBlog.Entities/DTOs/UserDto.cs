﻿using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Entities.Abstract;

namespace ProgrammersBlog.Entities.DTOs
{
    public class UserDto : DtoGetBase
    {
        public User User { get; set; }
    }
}
