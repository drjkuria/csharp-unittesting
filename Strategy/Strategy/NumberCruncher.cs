
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
            int count = 0;
            foreach(int number in numbers)
            {
                if (number < 0)
                {
                    count++;
                }
            }
            return count;
        }

        public int CountEven()
        {
            int count = 0;
            foreach(int number in numbers)
            {
                if(number % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
