using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Abstract;
using System.Collections.Generic;

namespace ProgrammersBlog.Data.Abstract
{
    public interface IArticleRepository : IEntityRepository<Article>
    {
    }
}
