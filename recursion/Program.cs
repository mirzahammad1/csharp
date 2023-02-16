using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LAB 13 - RECURSION");
            Program p = new Program();
            p.sum(10, 30);
            p.table(2, 1);
            p.multiply_num(1);
        }
        //
        int Sum = 0;
        public int sum(int start_num,int end_num)
        {
            if (start_num==end_num)
            {
                Console.WriteLine(Sum);
                return -1;
            }
            else
            {
                Sum += start_num;
                //Console.WriteLine(Sum);
                start_num++;
                return sum(start_num, end_num);
            }
        }
        public int table(int table_no,int count)
        {
            if (count==11)
            {
                return -1;
            }
            else
            {
                Console.WriteLine(table_no + " x " + count + " = " + table_no*count);
                count++;
                return table(table_no, count);
            }
        }
        int multi = 1;
        public void multiply_num(int num)
        {
            if (num<5)
            {
                multi *= num;
                num++;
                Console.WriteLine(multi);
                multiply_num(num);
            }
        }
    }
}