using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region 0
            #endregion 0
            /*
            #region 1
            Console.WriteLine("Task1:");
            Console.WriteLine("Input file location:");
            string input1 = Console.ReadLine();
            if (File.Exists(input1))
            {
                Console.WriteLine("In file:");
                Console.WriteLine(File.ReadAllText(input1));
            }
            else
            {
                Console.WriteLine("Can't fine file");
            }
            #endregion 1


            #region 2
            Console.WriteLine("Task2 :");
            List<int> arr2 = new List<int>();
            string s2 = " ";
            Console.Write("Read/write(1/2)?: ");
            s2 = Console.ReadLine();
            if (s2 == "1")
            {
                do
                {
                    Console.Write("Input integer (for ex - Enter): ");
                    s2 = Console.ReadLine();
                    if (int.TryParse(s2, out int num2))
                    {
                        arr2.Add(num2);
                    }
                    else
                    {
                        Console.WriteLine("Incorrec input - exit");
                        break;
                    }
                } while (s2 != "");

                foreach (int i in arr2)
                {
                    File.WriteAllText("Arr.txt", i.ToString() + " ");
                }
            }
            else if (s2 == "2")
            {
                string text2 = File.ReadAllText("Arr.txt");
                string[] texts2 = text2.Split(' ');
                foreach (string s in texts2)
                {
                    if (int.TryParse(s, out int num2))
                    {
                        arr2.Add(num2);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect data in file");
                        break;
                    }
                }
            }
            #endregion 2
            */

            #region 3
            Console.WriteLine("Task3:");
            Random r = new Random();
            string path1_3 = "Odd.txt";
            string path2_3 = "Even.txt";
            for (int i = 0; i < 10000; i++)
            {
                int num3 = r.Next();
                if (num3 % 2 == 0) { File.AppendAllText(path1_3, num3.ToString() + " "); }
                else { File.AppendAllText(path2_3, num3.ToString() + " " ); }
            }
            Console.WriteLine("Data file 1:");
            Console.WriteLine(File.ReadAllText(path1_3));
            Console.WriteLine("Data file 2:");
            Console.WriteLine(File.ReadAllText(path2_3));
            #endregion 3


            #region 4
            Console.WriteLine("Task4:");
            string path4 = "file.txt";
            Console.Write("Choose wariant(1/2/3):");
            string s4 = Console.ReadLine();
            string data4 = File.ReadAllText(path4);
            if (s4 == "1")
            {
                Console.Write("Input file to find:");
                string find4 = Console.ReadLine();
                int index = data4.IndexOf(find4);
                if (index != -1)
                {
                    Console.WriteLine("Finded at " +  index);
                }
                else
                {
                    Console.WriteLine("Not finded");
                }
            }
            if (s4 == "2")
            {
                Console.Write("Input file to find:");
                string find4 = Console.ReadLine();
                int count = 0;
                int index = 0;
                while ((index = data4.IndexOf(find4, index)) != -1)
                {
                    count++;
                    index += 1;
                }
                Console.WriteLine("Finded " + count + " times");
            }
            if (s4 == "3")
            {

                Console.Write("Input file to find:");
                string find4 = Console.ReadLine();
                find4.Reverse();
                int count = 0;
                int index = 0;
                while ((index = data4.IndexOf(find4, index)) != -1)
                {
                    count++;
                    index += find4.Length;
                }
                Console.WriteLine("Finded " + count + " times");
            }
            #endregion 4


            #region 5
            string path5 = "file5.txt";
            string p0 = ".?!";
            string p1 = "aeiouyAEIOUY";
            string p2 = "bcdfghjklmnpqrstvwxzBCDFGHJKLMNPQRSTVWXZ";
            string p3 = "abcdefghijklmnopqrstuvwxyz";
            string p4 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string p5 = "0123456789";
            int[] data5 = new int[6];
            string s5 = File.ReadAllText(path5);
            foreach(char s in s5)
            {
                if (p0.IndexOf(s) != -1) { data5[0] += 1; }
                if (p1.IndexOf(s) != -1) { data5[1] += 1; }
                if (p2.IndexOf(s) != -1) { data5[2] += 1; }
                if (p3.IndexOf(s) != -1) { data5[3] += 1; }
                if (p4.IndexOf(s) != -1) { data5[4] += 1; }
                if (p5.IndexOf(s) != -1) { data5[5] += 1; }
            }
            Console.WriteLine("Data: " + data5[0] + " " + data5[1] + " " + data5[2] + " " + data5[3] + " " + data5[4] + " " + data5[5]);
            #endregion 5
        }
    }
}
