using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Exercicio_Posts
{
    class Posts
    {
        public string _title {get; set;}
        public string _description {get; set;}
        public DateTime _datePost {get; private set;}
        public int _vote {get; private set;}

    public Posts()
        {
            _title = "Untitled";
            _datePost = DateTime.Now;
            _vote = 0;
            _description = "none";
        }

        public void AddVote()
        {
            _vote++;
        }

        public void SubVote()
        {
            _vote--;
        }

        public void PostFull()
        {
            Console.WriteLine("Posting at StackOverflow");
            Console.WriteLine("------------------------");
            Console.WriteLine(_title + " -- {0} Votes", _vote);
            Console.WriteLine("Posted on - {0}", _datePost.ToShortDateString());
            Console.WriteLine("------------------------");
            Console.WriteLine(_description);
            Console.WriteLine("-----------END----------");

        }
    }
}
