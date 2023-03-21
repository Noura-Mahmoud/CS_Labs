using System.Diagnostics;

namespace count_ones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            #region first case
            //int counter = 0;
            //for (int i = 1; i < 99999999; i++)
            //{
            //    string s = i.ToString();
            //    for (int j = 0; j < s.Length; j++)
            //    {
            //        if (s[j] == '1') counter++;
            //    }
            //}
            //Console.WriteLine(counter + " times");
            #endregion
            #region case 2
            //int totalOnes = 0;
            //for (int i = 1; i < 99999999; i++)
            //{
            //    //get each digit of the number and add it to total ones if digit is one  Such as   123456789 -> 1+2+3+4+5+6+7+8+9 = 45      
            //    int temp = i;
            //    while (temp > 0)
            //    {
            //        int lastDigit = temp % 10;
            //        if (lastDigit == 1) { totalOnes++; }
            //        temp /= 10;
            //    }
            //}
            //Console.WriteLine("The total number of occurrences of 1 from 1 to 99,999,999 is " + totalOnes);
            #endregion
            #region case 3
            double count = 0;
            int digits = 8;
            count = digits * Math.Pow(10,(digits - 1));
            Console.WriteLine("The total number of occurrences of 1 from 1 to 99,999,999 is " + count);

            #endregion
            // Format and display the TimeSpan value.
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}