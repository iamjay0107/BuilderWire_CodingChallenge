using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Query
{
    public class Article : IArticle, IBuilder
    {
        #region Variable

        private readonly string[] EXCLUDE_STRINGS = { "Mr.", "Mrs.", "e.g." };

        private readonly string _article;

        private List<string> ArticleList = new List<string>();

        public IEnumerable<string> Articles { get { return this.ArticleList.AsEnumerable(); } }
        public int ArticleLength { get  { return ArticleList.Count; } }

        private List<string> _articles
        {
            get { return _article.Split(' ').ToList(); }
        }

        #endregion Variable

        #region Constructor
        /// <summary>
        /// Initializes a new instance of Article
        /// </summary>
        /// <param name="article"></param>
        public Article(string article)
        {
            _article = article;
            this.Build();
        }
        #endregion Constructor

        #region Method
        /// <summary>
        /// Build's article and converts it to array.
        /// </summary>
        public void Build()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _articles.Count; i++)
            {
                if (EXCLUDE_STRINGS.Contains(_articles[i]))
                    sb.AppendFormat("{0} ", _articles[i]);
                else
                {
                    if (_articles[i].Contains("."))
                    {
                        sb.AppendFormat("{0}", _articles[i].TrimAndReplace(".", ""));
                        ArticleList.Add(sb.ToString());
                        sb.Clear();
                    }                                                
                    else
                        sb.AppendFormat("{0} ", _articles[i]);
                }
            }
        }
        #endregion Method
    }
}
