
namespace Strategy
{
    public class NumberCruncher
    {
        private readonly int[] numbers;
        

        public NumberCruncher(params int[] numbers)
        {
            this.numbers = numbers;
        }

        public int CountPositive()
        {
            int count = 0;
            foreach(int number in numbers)
            {
                if (number >= 0)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountNegative()
        {
            return 0;
        }
    }
}
