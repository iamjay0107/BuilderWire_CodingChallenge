using BuilderWireCodingChallenge.Tests.Model;
using DataAccess;
using DataAccess.Model;
using DataAccess.Query;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace BuilderWireCodingChallenge.Tests
{
    [TestClass]
    public class ParagraphTests
    {
        private static IArticle article;
        private static IWord words;
        private static IQueryHandler<ParagraphResponse> _queryHandler;


        [TestMethod]
        public void TestAritcleWordInput()
        {
            article = new Article(Constants.Article);
            Assert.AreEqual(12, article.ArticleLength);

            words = new Word(Constants.Word.Split(',').ToList());
            Assert.AreEqual(102, words.WordLength);
        }

        [TestMethod]
        public void TestAritcleWordValidation()
        {
            _queryHandler = new GetParagraphOutputHandler(null, new Word(new List<string>() { "test" }));
            var handleArticle = _queryHandler.Handle();

            Assert.AreEqual("Failure", handleArticle.Status);
            Assert.AreEqual("Invalid Article. Please check input.", handleArticle.Message);

            article = new Article(Constants.Article);
            _queryHandler = new GetParagraphOutputHandler(article as Article, null);
            var handleWord = _queryHandler.Handle();

            Assert.AreEqual("Failure", handleWord.Status);
            Assert.AreEqual("Invalid Word. Please check input.", handleWord.Message);
        }

        [TestMethod]
        public void TestParagraphOutput()
        {
            article = new Article(Constants.Article);
            words = new Word(Constants.Word.Split(',').ToList());

            _queryHandler = new GetParagraphOutputHandler(article as Article, words as Word);

            string[] output = Constants.WordOutput.Split('|');

            var handleResponse = _queryHandler.Handle();

            for (int i = 0; i < output.Length; i++)
                Assert.AreEqual(output[i].ToLowerInvariant().Trim(), handleResponse.ParagraphResult.ToArray()[i].ToLowerInvariant().Trim());
        }

    }
}
