namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете дума: ");
            string input = Console.ReadLine().ToLower(); 

            Queue<char> queue = new Queue<char>();
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                queue.Enqueue(ch);
                stack.Push(ch);
            }

            bool isPalindrome = true;
            while (queue.Count > 0)
            {
                if (queue.Dequeue() != stack.Pop())
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
                Console.WriteLine("Думата е палиндром.");
            else
                Console.WriteLine("Думата не е палиндром.");
        }
    }
}
