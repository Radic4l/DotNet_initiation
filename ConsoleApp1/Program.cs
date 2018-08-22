using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {

        static void Main(string[] args)
        {
            //-------Variable-------
            bool exitProg = false;
            DateTime Mydate = DateTime.Now;
            Messages msg  = new Messages(8, 13, 18);
            //ConsoleKey test = ConsoleKey.Enter;

            //-------Execute-------

            while (exitProg != true)
            {
                Console.WriteLine(msg.HelloMessages() + "et bienvenue utilisateur " + Environment.UserName);
                Console.WriteLine("Nous somme le " + Mydate.Day + " Et il est " + Mydate.Hour + "H" + Mydate.Minute);
                Console.WriteLine("Entrée exit pour quitter le programme");
                string saisie = Console.ReadLine();

                if (exitProg == false)
                {
                    Console.WriteLine("vous avez saisie " + saisie);
                    

                    if (saisie == "exit")
                    {
                        Environment.Exit(0);
                    } else
                    {
                        Console.WriteLine("Veuillez rentrer la bonne Valeur");
                    }
                }
            }
        }
    }
}
