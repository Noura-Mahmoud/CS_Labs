namespace reverse_sentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String sentence = "this is a test";
            string[] words = sentence.Split(' ');
            Array.Reverse(words);
            sentence = string.Join(" ", words);
            Console.WriteLine(sentence);
        }
    }
}