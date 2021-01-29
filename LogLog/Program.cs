/* Simple log log n program
 * 
 * Henry Baldacci (hb43), Calvin University, 9/2020
 */
using System;

namespace LogLog
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nEnter N:(0 to exit) ");
                int n = int.Parse(Console.ReadLine());
                
                // Exit case
                if (n == 0) break; 
                
                int log_count = 0;
                int final_count = 0;
                
                // First log count
                while (n > 1)
                {
                    n = n / 2;
                    log_count += 1;
                }
                
                // Second log count
                while (log_count > 1)
                {
                    log_count = log_count / 2;
                    final_count += 1;
                }
                
                Console.Write("log log n is " + final_count);
            }
        }
    }
}
