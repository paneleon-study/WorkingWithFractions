using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123Assignment2;
using System;

namespace TweetMethodsTests
{
    [TestClass]
    public class ParseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // given
            string tweetString = "Joke\tSteve Carell\tJenna Fischer\tWhat is a Podcast?\t1250";
            Tweet expectedTweet = new Tweet("Steve Carell", "Jenna Fischer", "What is a Podcast?", "Joke", "1250");

            // when
            Tweet actualTweet = Tweet.Parse(tweetString);

            // then
            Assert.AreEqual(expectedTweet.From, actualTweet.From);
            Assert.AreEqual(expectedTweet.To, actualTweet.To);
            Assert.AreEqual(expectedTweet.Body, actualTweet.Body);
            Assert.AreEqual(expectedTweet.Tag, actualTweet.Tag);
            Assert.AreEqual(expectedTweet.Id, actualTweet.Id);
        }
    }
}
