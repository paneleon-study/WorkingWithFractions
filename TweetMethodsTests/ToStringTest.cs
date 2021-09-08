using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123Assignment2;
using System;

namespace TweetMethodsTests
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // given
            Tweet sampleTweet = new Tweet("Steve Carell", "Jenna Fischer", "What is a Podcast?", "Joke");
            string expectedString = $"-------------- \nFrom: Steve Carell \nTo: Jenna Fischer \n#Joke \nWhat is a Podcast? \n";

            // when
            string actualString = sampleTweet.ToString();

            // then
            Assert.AreEqual(expectedString, actualString);
        }
    }
}
