using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123Assignment2;
using System;

namespace TweetMethodsTests
{
    [TestClass]
    public class TweetConstructorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // given
            string expectedFrom = "Steve Carell";
            string expectedTo = "Jenna Fischer";
            string expectedBody = "What is a Podcast?";
            string expectedTag = "Joke";
            string expectedId = "1";

            // when
            Tweet sampleTweet = new Tweet("Steve Carell", "Jenna Fischer", "What is a Podcast?", "Joke");

            // then
            Assert.AreEqual(expectedFrom, sampleTweet.From);
            Assert.AreEqual(expectedTo, sampleTweet.To);
            Assert.AreEqual(expectedBody, sampleTweet.Body);
            Assert.AreEqual(expectedTag, sampleTweet.Tag);
            Assert.AreEqual(expectedId, sampleTweet.Id);
        }
    }
}
