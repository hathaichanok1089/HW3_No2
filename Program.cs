class Program
{
    static void Main(string[] args)
    {
        bool isEnd = false;
        Queue<char> queue = new Queue<char>();
        while (!isEnd)
        {
            Console.Write("Enter the size:");
            char input = Convert.ToChar(Console.ReadLine());
            if(input != 'S' && input != 'M' && input != 'L')
            {
                isEnd =true;
            }
            else
            {
                queue.Push(input);
            }
        }

        while (queue.GetLength() != 0)
        {
            char x = queue.Pop();

            if(x == 'L')
            {
                queue.Push('M');
                queue.Push('M');
                Console.Write('1');
            }
            else if (x == 'M')
            {
                queue.Push('S');
                queue.Push('S');
                queue.Push('S');
                Console.Write('2');
            }
            else if (x == 'S')
            {
                Console.Write('3');
            }
        }

    }
}