using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Exercicio_Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            var postNow = new Posts()
            {

                //postNow._datePost = new DateTime(2017, 1, 1);// nao complia pq é privado

                _title = "Nisi ut aliquid ex ea commodi consequatur?",
                _description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor 
incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation 
ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit 
in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat 
non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            };
            postNow.AddVote();
            postNow.AddVote();
            postNow.AddVote();
            postNow.AddVote();
            postNow.AddVote();

            postNow.SubVote();

            postNow.PostFull();
        }
    }
}
