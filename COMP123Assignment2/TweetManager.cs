using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP123Assignment2
{
    public static class TweetManager
    {
        private static List<Tweet> TWEETS;
        private static string FILENAME = "Assignment_02_TweetFile.txt";

        static TweetManager()
        {
            TWEETS = new List<Tweet>();

            using (StreamReader reader = new StreamReader(FILENAME))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Tweet newTweet = Tweet.Parse(line);
                    TWEETS.Add(newTweet);
                }
            }
        }

        public static void Initialize()
        {
            TWEETS = new List<Tweet>();
            Tweet tweet1 = new Tweet("Leonardo DiCaprio", "World Economic Forum", "We have pushed the planet to its limit.", "Climate");
            TWEETS.Add(tweet1);
            Tweet tweet2 = new Tweet("Tom Hanks", "Tom Hanks", "Dear Internet- my beard loved its time with you. Hanx", "Joke");
            TWEETS.Add(tweet2);
            Tweet tweet3 = new Tweet("Meryl Streep", "Hugh Jackman", "Good morning Australia. 2nd sunrise in quarantine.", "Covid");
            TWEETS.Add(tweet3);
            Tweet tweet4 = new Tweet("Steve Carell", "Jenna Fischer", "I CANNOT WAIT for podcast Office Ladies!!(What is a Podcast?)", "Netflix");
            TWEETS.Add(tweet4);
            Tweet tweet5 = new Tweet("Steve Carell", "Steve Carell", "I can see how typing the word 'proll' instead of 'probably' is a huge time saver. Much like the cotton gin..", "Joke");
            TWEETS.Add(tweet5);
        }

        public static void ShowAll()
        {
            foreach(Tweet tweet in TWEETS)
            {
                Console.WriteLine(tweet);
            }
        }

        public static void ShowAll(string tag)
        {
            foreach (Tweet tweet in TWEETS)
            {
                if (tweet.Tag == tag)
                {
                    Console.WriteLine(tweet);
                }   
            }
        }

    }
}
