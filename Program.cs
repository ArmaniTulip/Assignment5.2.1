namespace Assignment5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lastWord = {"Hello World" };
            string space = " ";

            for (int i = 0; i - 1 < lastWord.Length; i++)
            {
                string[] words = lastWord[i].Split(space.ToCharArray());

                string last = words[words.Length - 1];

                int length = last.Length;

                Console.WriteLine($"{length} is the length of the last word.");
            }
        }
    }
}
