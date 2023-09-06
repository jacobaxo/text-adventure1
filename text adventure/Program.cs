using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace text_adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        static void Start()
        {
            Console.WriteLine("Welcome traveller. What is your name? ");
            string CharName = Console.ReadLine();
            Console.WriteLine($"Smimble: Hello {CharName}, welcome to the tavern");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine($"Would you like to take a <quest> or <drink> {CharName}?");
            string quest = Console.ReadLine();
            if (quest.Contains("quest") == true)
            {
                Console.WriteLine($"{CharName} gets a party together in the tavern and you decide to go somewhere on he map");
                Console.WriteLine("you can either <take quest> or <adventure>");

                if (quest.Contains("take quest") == true)
                {
                    Console.WriteLine("you get a quest to beat up some dragon, its not really speical. its kinda just a big stupid lizard, like not as cool as a crocodile though, imagine a big gecko.");
                }
                else if (quest.Contains("adventure") == true)
                {
                    Console.WriteLine("you get up to some wacky highjinks or something i dunno but you find some treasure and call it a day");
                }
            }
            else if (quest.Contains("drink") == true)
            {
                Console.WriteLine("you drink and you get into a bar fight what will you do");
                Console.WriteLine("<fight> or <run>");
                string bar = Console.ReadLine();
                if (bar.Contains("fight") == true)
                {
                    Console.WriteLine("you drink and you get into a bar fight what will you do");
                }
                else if (bar.Contains("run") == true)
                {
                    Console.WriteLine("you run about a mile, it was kinda sad!");
                }
                else
                {
                    Console.WriteLine("thats not an option sorrry!");
                }
            }
            else
            {
                Console.WriteLine("thats not an option sorrry!");
            }
            Console.ReadKey();
        }
    }
}
