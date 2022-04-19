using Homework1.Interface;
using System;

namespace Homework1
{
    class Program
    {
        
        
            private static object password;

            static void Main(string[] args)
            {
                Console.WriteLine("Sifreni Daxil Edin");

                string password = Console.ReadLine();
                string email = "ilkinar@code.edu.az";
                User user = new User(email, password);


                user.FullName = "Rzayev Ilkin";
                user.ShowInfo();



            }
        }
    }

