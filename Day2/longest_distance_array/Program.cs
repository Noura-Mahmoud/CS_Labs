namespace longest_distance_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            //arr = new int[12];
            //Console.WriteLine("enter array of intger values sequentialy");
            //for (int i=0; i<arr.Length; i++)
            //    arr[i] = int.Parse(Console.ReadLine());

            #region sol 1 

            //IDictionary<int, int> myDict = new Dictionary<int, int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int max_dist = 0;
            //    if (myDict.ContainsKey(arr[i]))
            //        myDict[arr[i]] = Math.Max(max_dist, i - myDict[arr[i]]);
            //    else
            //        myDict.Add(arr[i], i);
            //}
            //for (int x = 0; x < myDict.Count; x++)
            //{
            //    Console.WriteLine("{0} --> {1}", myDict.Keys.ElementAt(x),
            //    myDict[myDict.Keys.ElementAt(x)]);
            //}
            #endregion

            #region sol2
            arr = new int[] { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };
            int max = 0;
            int num = 0;

            for (int i = 0; i< arr.Length; i++)
            {
                int distance = 0;
                for (int j = arr.Length-1; j > i; j--)
                    if (arr[j] == arr[i])
                    {
                        distance = j - i -1;
                        break;
                    }
                if (distance > max)
                {
                    max = distance;
                    num = arr[i];
                }

                //Console.WriteLine($"num {arr[i]} --> {distance}");
            }
            Console.WriteLine($"num {num} --> {max}");
            #endregion 
        }
    }
}