using System;
namespace Project2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string output = Console.ReadLine();
            int res = 0;
            string point = "";
            int counter = 0;
            int getResult(int res_now, string point)
            {
                int point_int = Convert.ToInt32(point);
                return res_now + point_int;
            }
            foreach (char i in output)
            {
                counter++;
                if (char.IsDigit(i) && output.Length != counter)
                {
                    point += i;

                }
                else if(char.IsDigit(i) && output.Length == counter)
                {
                    point += i;
                    res = getResult(res, point.ToString());
                }
                else
                {
                    if (point != "")
                    {
                        res = getResult(res, point.ToString());
                        point = "";
                    }
                }
                
            }
            Console.WriteLine(res);
        }
    }
}
