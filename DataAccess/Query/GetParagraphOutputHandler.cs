using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Query
{
    public class GetParagraphOutputHandler : IQueryHandler<ParagraphResponse>
    {
        
        private readonly IArticle _article;
        private readonly IWord _word;

        public GetParagraphOutputHandler(Article article, Word word)
        {
            _article = article;
            _word = word;
        }

        /// <summary>
        /// Handles Logic for Paragraph Response
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public ParagraphResponse Handle()
        {
            if (_article == null || _article.Articles.Count() < 1)
                return new ParagraphResponse() { Message = "Invalid Article. Please check input.", Status = "Failure" };

            if (_word == null || _word.Words.Count() < 1)
                return new ParagraphResponse() { Message = "Invalid Word. Please check input.", Status = "Failure" };

            GenerateOutput();

            return new ParagraphResponse() { Message = "", Status = "Success", ParagraphResult =_word.FormattedWords };
        }

        /// <summary>
        /// Responsible for Generating the Output for paragraphs
        /// </summary>
        private void GenerateOutput()
        {
            StringBuilder sb = new StringBuilder();
            List<string> pargResult = new List<string>();
            foreach (var word in _word.Words)
            {
                List<int> elementPos = new List<int>();
                sb.Clear();

                for (int i = 0; i < _article.Articles.Count(); i++)
                {
                    if (_article.Articles.ElementAt(i).ToLowerInvariant().IndexOf(word) >= 0)                    
                        elementPos.AddRange(CountWord((i + 1), word, _article.Articles.ElementAt(i)));                    
                }

                sb.AppendFormat("{{{0}:{1}}}", elementPos.Count, string.Join(",", elementPos));
                pargResult.Add(sb.ToString());
            }

            _word.SetValues(pargResult);
        }

        /// <summary>
        /// Count's the word specified on the single paragraph
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="word"></param>
        /// <param name="article"></param>
        /// <returns></returns>
        private List<int> CountWord(int pos, string word, string article)
        {
            List<int> countWrd = new List<int>();
            if(!string.IsNullOrEmpty(article))
            {
                string[] articleArr = article.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if(article.Any())
                {
                    for (int i = 0; i < articleArr.Length; i++)
                    {
                        if (word == articleArr[i].ToLowerInvariant().TrimAndReplace(",", ""))
                            countWrd.Add(pos);
                    }
                }
            }

            return countWrd;
        }

    }
}
