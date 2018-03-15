using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    
    //Assignment 2
    //Author: Samuel A.M. Foley
    class Program
    {
        private Models.User user = new Models.User();

        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            // Exercise 1:
            // Display all passwords that say hello.
            var exercise_1 = users.Where(x => x.Password.Contains("hello"));

            foreach (Models.User passes  in exercise_1)
            {
                Console.WriteLine("User: {0} Password: {1}", passes.Name, passes.Password);
            }

            //Exercise 2: 
            //Delete any passwords that are the lower-cased version of their Name. Do not just look for "steve". It has to be data-driven. Hint: Remove or RemoveAll
            users.RemoveAll(x => x.Name.ToLower() == x.Password);

            foreach (Models.User exercise_2 in users)
            {
                Console.WriteLine("User: {0} Password: {1}", exercise_2.Name, exercise_2.Password);
            }

            //Exercise 3: 
            //Delete the first User that has the password "hello". Hint: First or FirstOrDefault
            var remove = users.First(x => x.Password.Contains("hello"));
            users.Remove(remove);

            //Exercise 4: 
            //Display to the console the remaining users with their Name and Password.
            foreach (Models.User exercise_4 in users)
            {
                Console.WriteLine("User: {0} Password: {1}", exercise_4.Name, exercise_4.Password);
            }
            Console.ReadLine();
        }
    }
}
