using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Model
{
    public class ParagraphResponse : ErrorResponse
    {
        /// <summary>
        /// Get's or set's the paragraph Result
        /// </summary>
        public IEnumerable<string> ParagraphResult { get; set; }

    }
}
