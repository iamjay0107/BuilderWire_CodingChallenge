using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Query
{
    public class Word : IWord, IBuilder
    {

        #region Variables

        private List<string> _words;
        private int WRD_CTR = 0;
        private int LETTER_CTR = 1;

        private List<string> WordList = new List<string>();

        /// <summary>
        /// Get's only the letter from a-z
        /// </summary>
        private char[] GetLetter
        {
            get
            {
                return Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
            }
        }

        public List<string> FormattedWords { get; set; }

        public IEnumerable<string> Words { get { return _words; } }

        public int WordLength { get { return WordList.Count; } }


        #endregion Variables

        #region Constructor
        /// <summary>
        /// Initializes a new instance of Word 
        /// </summary>
        /// <param name="words"></param>
        public Word(List<string> words)
        {
            _words = words;
            this.Build();
        }
        #endregion Constructor

        #region Method
        /// <summary>
        /// Set's Paragraph's final result
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="words"></param>
        /// <param name="paragraphResult"></param>
        /// <returns></returns>
        private string SetWord(string letter, string words)
        {
            return $"{letter}. {words}";
        }

        /// <summary>
        /// Set's a multiple letters
        /// </summary>
        /// <param name="letter"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private string SetMultipleLetters(char letter, int count)
        {
            StringBuilder sbLetter = new StringBuilder();

            for (int i = 1; i <= count; i++)
                sbLetter.Append(letter);

            return sbLetter.ToString();
        }

        /// <summary>
        /// Build's Word into a list
        /// </summary>
        public void Build()
        {
            List<string> words = new List<string>();

            if ((_words ??= new List<string>()).Any())
            {
                for (int i = 0; i < _words.Count; i++)
                {
                    string multipleLetters = SetMultipleLetters(GetLetter[WRD_CTR], LETTER_CTR);

                    words.Add(SetWord(multipleLetters, _words.ElementAt(i))); //store formatted words

                    if (WRD_CTR >= GetLetter.Length - 1)
                    {
                        WRD_CTR = 0;
                        LETTER_CTR++;
                    }
                    else
                        WRD_CTR++;
                }
            }

            WordList = words;
        }

        /// <summary>
        /// Set's Formatted values 
        /// </summary>
        /// <param name="values"></param>
        public void SetValues(List<string> values)
        {
            if (values.Any())
            {
                this.FormattedWords = new List<string>();
                for (int i = 0; i < values.Count; i++)
                {
                    string frmtWord = string.Format("{0} {1}", this.WordList.ElementAt(i), values[i]);
                    FormattedWords.Add(frmtWord);
                }        
            }            
        }
        #endregion Method
    }
}
