using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            TweetManager.ShowAll();
            Console.WriteLine("========= By tag =========");
            TweetManager.ShowAll("Ford");

            Console.WriteLine("========= After initialization =========");
            TweetManager.Initialize();
            TweetManager.ShowAll();
            Console.WriteLine("========= By tag =========");
            TweetManager.ShowAll("Joke");

            Console.WriteLine("===== Creating a tweet =====");
            Tweet sampleTweet = new Tweet("Steve Carell", "Jenna Fischer", "What is a Podcast?", "Joke");
            Console.WriteLine(sampleTweet);
        }
    }
}
