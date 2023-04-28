using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Director
    {
        private TheBuilder theBuilder;
        public Director(TheBuilder builder)
        {
            theBuilder = builder;
        }
        public void Constrcut()
        {
            theBuilder.MakeTitle("Greeting");
            theBuilder.MakeString("From morning to afternoon");
            theBuilder.MakeItems(new string[] { "Good morning", "Good afternoon" });
            theBuilder.MakeString("At night");
            theBuilder.MakeItems(new string[] { "Good evening", "Good night", "Good bye" });
            theBuilder.Close();
        }
    }
}
