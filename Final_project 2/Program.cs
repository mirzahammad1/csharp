using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.WebRequestMethods;

namespace Final_project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program filling_in_task = new Program();
            filling_in_task.id();
            filling_in_task.fine();
        }
        public void id()
        {
            StreamWriter ids = new StreamWriter("student_ids.txt");
            int[] student_ids = { 1234, 5678, 9101, 1213 };
            foreach (int id in student_ids)
            {
                ids.WriteLine(id);
            }
            StreamWriter books = new StreamWriter("books.txt");
            books.WriteLine("Books Details");
            books.WriteLine("ACADEMIC BOOKS");
            string[] academic = {"c# Head First \nAuthor : Andrew Stellman \nEdition : 3rd" ,
                                "Computer Science An Overview \nAuthor : Glenn Brookshear \nEdition : 12th",
                                "Significance of Islam \nAuthor : George B.Thomas \nEdition : 9th"};
            foreach (var item in academic)
            {
                books.WriteLine(item);

            }
            books.WriteLine("NOVELS");
            string[] novel = { "Fire & Blood \nAuthor : George R.R.Martin \nGenre : Fantasy",
                             "The Lady of the Lake \nAuthor : Andrzej Sapkowski \nGenre : Fantasy",
                             "Harry Potter \nAuthor : J.K Rowling \nGenre : Fantasy"};
            foreach (var item in novel)
            {
                books.WriteLine(item);
            }
            books.WriteLine("HISTORY BOOKS");
            string[] history = { "The Idea of the Muslim World:A global Intellectual History \nAuthor : Cemil Aydin \nPublished:2017",
                                "Arabs \nAuthor : Tim Mackintosh-Smith \nPublished : 2019",
                                "The Court of the Caliphs \nAuthor : Hugh N.Kennedy \nPublished : 2004"};
            foreach (var item in history)
            {
                books.WriteLine(item);
            }
            ids.Close();
            books.Close();
            Console.WriteLine("Enter Your Student id : ");
            int user_input_id = int.Parse(Console.ReadLine());
            for (int i = 0; i < student_ids.Length; i++)
            {
                if (student_ids[i] == user_input_id)
                {
                    Console.WriteLine("Please Select Your Category from :");
                    Console.WriteLine(" 1. Acedamic\n 2. Novels\n 3. History");
                    char ch = char.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            Console.WriteLine(" 1. PF\n 2. IICT\n 3. PIS");
                            char book = char.Parse(Console.ReadLine());
                            if (book == '1')
                            {
                                Console.WriteLine(academic[0]);
                                Console.WriteLine("Book issued to id : " + student_ids[i]);
                            }
                            else if (book == '2')
                            {
                                Console.WriteLine(academic[1]);
                                Console.WriteLine("BOOK IS NOT AVAILABLE");
                            }
                            else if (book == '3')
                            {
                                Console.WriteLine(academic[2]);
                                Console.WriteLine("Book issued to id : " + student_ids[i]);
                            }
                            else
                            {
                                Console.WriteLine("INVALID INPUT");
                            }
                            break;
                        case '2':
                            Console.WriteLine("1.Fire & Blood\n 2.The Lady of the Lake \n 3.Harry Potter");
                            book = char.Parse(Console.ReadLine());
                            if (book == '1')
                            {
                                Console.WriteLine(novel[0]);
                                Console.WriteLine("Book issued to id : " + student_ids[i]);
                            }
                            else if (book == '2')
                            {
                                Console.WriteLine(novel[1]);
                                Console.WriteLine("Book issued to id : " + student_ids[i]);
                            }
                            else if (book == '3')
                            {
                                Console.WriteLine(novel[2]);
                                Console.WriteLine("Book issued to id : " + student_ids[i]);
                            }
                            else
                            {
                                Console.WriteLine("INVALID INPUT");
                            }
                            break;
                        case '3':
                            Console.WriteLine("1.The Idea of the Muslim World:A global Intellectual History\n 2.Arabs\n 3.The Court of the Caliphs");
                            book = char.Parse(Console.ReadLine());
                            if (book == '1')
                            {
                                Console.WriteLine(history[0]);
                                Console.WriteLine("Book issued to id : " + student_ids[i]);
                            }
                            else if (book == '2')
                            {
                                Console.WriteLine(history[1]);
                                Console.WriteLine("Book issued to id : " + student_ids[i]);
                            }
                            else if (book == '3')
                            {
                                Console.WriteLine(history[2]);
                                Console.WriteLine("Book issued to id : " + student_ids[i]);
                            }
                            else
                            {
                                Console.WriteLine("INVALID INPUT");
                            }
                            break;
                        default:
                            Console.WriteLine("INVALID INPUT");
                            break;
                    }
                }
            }
            Console.WriteLine("\n");   

        }
        public void fine()
        {
            Console.WriteLine("Do you want to know how much fine is charged");
            Console.WriteLine("1.YES\n2.NO");
            char op = char.Parse(Console.ReadLine());
            if (op=='1')
            {
                Console.WriteLine("Enter current date : ");
                int date = int.Parse(Console.ReadLine());
                Console.WriteLine("Your issue date was : 5-12-23");
                int f = (((date + 5) - 15) + 5);
                if (f<=15)
                {
                    Console.WriteLine("You have return the book {0} days",f);
                    Console.WriteLine("No fine is charged");
                    Console.WriteLine("Your book is returned");
                }
                else if (f>=15)
                {
                    Console.WriteLine("You have return the book {0} days",f);
                    Console.WriteLine("Your fine is " + (f-15) + "$");
                }
            }
            else if (op=='2')
            {
                Console.WriteLine("Thank you");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}