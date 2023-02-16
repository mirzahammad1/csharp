// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Net.NetworkInformation;

namespace Text_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Program filling = new Program();
            filling.add_data_in_file();
            filling.read_data();
            Console.ReadKey();
        }
        public void add_data_in_file()
        {
            StreamWriter to_write_data = new StreamWriter("student.txt");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter name : " + i);
                to_write_data.WriteLine();//to write data in text file (notepad)
                string name = Console.ReadLine();
                Console.WriteLine("enter student id : ");
                int id = int.Parse(Console.ReadLine());
                to_write_data.WriteLine(name + " , " + id);
            }
            to_write_data.Close();
        }

        public void read_data()
        {
            StreamReader get_data = new StreamReader("student.txt");
            string line;
            while ((line = get_data.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                foreach (var item in parts)
                {
                    Console.Write(item + " ");
                }
            }
            get_data.Close();
        }
        public void search_data()
        {
            StreamReader get_data = new StreamReader("student.txt");
            string search = Console.ReadLine();
            string line;
            while ((line = get_data.ReadLine()) != null)
            {
                if (line.Contains(search))
                {
                    Console.WriteLine(line);
                }
            }
            get_data.Close();
        }

        public void delet_data()
        {
            StreamReader get_data = new StreamReader("student.txt");
            StreamWriter temp_file = new StreamWriter("temp.txt");
            string search = Console.ReadLine();
            string line;
            while ((line = get_data.ReadLine()) != null)
            {
                if (line.Contains(search))
                {
                    // neglect

                }
                else
                {
                    // add in temp
                    temp_file.WriteLine(line);
                }
            }
            get_data.Close();
            temp_file.Close();
            File.Delete("student.txt");
            File.Copy("temp.txt", "student.txt");
            File.Delete("temp.txt");
        }
    }
}

        


    