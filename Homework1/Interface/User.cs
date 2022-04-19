using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1.Interface
{
    class User : IAccount
    {
        public string FullName;
        public string Email;
        private string _password;
        public string PassWord
        {
            get
            {
                return _password;
            }


            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;

                }


            }
        }

        public User(string email, string pasword)
        {
            Email = email;
            PassWord = pasword;


        }
        public bool PasswordChecker(string password)
        {
            bool check = false;
            bool check1 = false;

            bool check2 = false;


            if (password.Length >= 8)
            {


                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsUpper(password[i]))
                    {
                        check = true;



                    }
                    else if (char.IsDigit(password[i]))
                    {
                        check1 = true;

                    }
                    else if (char.IsLower(password[i]))
                    {
                        check2 = true;
                    }

                }
                if (check && check1 && check2)
                {
                    return true;

                }
                while (check || check1 || check2)
                {
                    Console.WriteLine(" Sifreni Yeniden Daxil Edin");
                    string a = Console.ReadLine();



                }


            }
            else
            {
                Console.WriteLine("Sifre 8 reqemden az olmamalidir!!!");
            }

            return false;

        }

        public void ShowInfo()
        {
            Console.WriteLine($"ad: {FullName}");
            Console.WriteLine($"email: {Email}");

        }
    }
    }
