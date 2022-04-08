using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Query
{
    public interface IArticle
    {
        public IEnumerable<string> Articles { get; }
        public int ArticleLength { get; }
    }
}
