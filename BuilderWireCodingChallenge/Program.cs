using DataAccess;
using DataAccess.Model;
using DataAccess.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderWireCodingChallenge
{
    class Program
    {
        private static IQueryHandler<ParagraphResponse> _queryHandler;
        private static List<string> wordInput = new List<string>();
        private static IArticle article;
        private static IWord words;

        static void Main(string[] args)
        {                       
            string line;
            
            Console.Write("Input Article: ");
            string articleInput = Console.ReadLine();

            article = new Article(articleInput);

            Console.WriteLine("Input Words: ");

            while ((line = Console.ReadLine()) != string.Empty)
            {
                wordInput.Add(line);
            }

            words = new Word(wordInput);
            Console.Clear();

            PrintOutput();
        }

        /// <summary>
        /// Set's the paragraph to read-only
        /// </summary>
        private static ParagraphResponse GetParagraph
        {
            get
            {
                _queryHandler = new GetParagraphOutputHandler(article as Article, words as Word);
                return _queryHandler.Handle();
            }
        }

        /// <summary>
        /// Prints the output
        /// </summary>
        private static void PrintOutput()
        {
            if(GetParagraph != null)
            {
                foreach (var word in (GetParagraph.ParagraphResult ??= new List<string>()))
                    Console.WriteLine(word);
            }
        }
    }
}
