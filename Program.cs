namespace project80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * EEEEE
             * DDDD
             * CCC
             * BB
             * A
             * 
             * 
             */
            int n = 5;
            for(int i =n+65; i>=65; i--)
            {
                for(int j = i; j<65+n; j++)
                {
                    Console.Write((char)i );
                }
                Console.WriteLine();
            }
       
            
        }
    }
}