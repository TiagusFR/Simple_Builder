using System;

namespace Simple_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

             /*First Aproach 
             
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello");
            builder.AddChild("li", "world");
            Console.WriteLine(builder.ToString());
            */

            
            //Fluent Aproach

            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello").AddChild("li,", "world");
            Console.WriteLine(builder.ToString());
            
        }
    }
}