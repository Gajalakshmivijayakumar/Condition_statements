namespace Demo_program
{
    class If
    {
        static void Main(string[] args)
        {
            int hours = 10;
            if (hours > 0 && hours <12)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if(hours >= 12 && hours < 18) 
            {
                Console.WriteLine("Good Evening!!");
            }
            else
            {
                Console.WriteLine("Good noon!!");
            }
                
        }
    }
}