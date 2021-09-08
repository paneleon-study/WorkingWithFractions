using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Assignment2
{
    public class Tweet
    {
        private static int CURRENT_ID;

        public string From { get; }
        public string To { get; }
        public string Body { get; }
        public string Tag { get; }
        public string Id { get; }

        public Tweet(string from, string to, string body, string tag)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = Convert.ToString(CURRENT_ID);
            CURRENT_ID += 1;
        }

        public Tweet(string from, string to, string body, string tag, string id)
        {
            From = from;
            To = to;
            Body = body;
            Tag = tag;
            Id = id;
        }

        public override string ToString()
        {
            if (Body.Length > 40)
            {
                return $"-------------- \nFrom: {From} \nTo: {To} \n#{Tag} \n{Body.Substring(0, 40)}... \n";
            }
            return $"-------------- \nFrom: {From} \nTo: {To} \n#{Tag} \n{Body} \n";
        }

        public static Tweet Parse(string line)
        {
            string[] words = line.Split(new char[] { '\t' });

            string tag = words[0];
            string from = words[1];
            string to = words[2];
            string body = words[3];
            string id = words[4];

            return new Tweet(from, to, body, tag, id);
        }
    }
}
