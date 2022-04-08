using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Query
{
    public interface IWord
    {
        public List<string> FormattedWords { get; set; }
        public IEnumerable<string> Words { get; }
        public int WordLength { get; }
        void SetValues(List<string> values);
    }
}
