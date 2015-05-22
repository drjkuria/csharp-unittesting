
namespace Strategy
{
    public class NumberCruncher
    {
        private readonly int[] numbers;
        private Filter filter;
        

        public NumberCruncher(params int[] numbers)
        {
            this.numbers = numbers;
        }

        public NumberCruncher(Filter filter, params int[] numbers)
        {
            this.filter = filter;
            this.numbers = numbers;
        }

        public int CountPositive()
        {
            int count = 0;
            foreach(int number in numbers)
            {
                count = filter.NumbersCount(count, number);
            }
            return count;
        }

        

        public int CountNegative()
        {
            int count = 0;
            foreach(int number in numbers)
            {
                count = filter.NumbersCount(count, number);
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

        public int CountOdd()
        {
            int count = 0;
            foreach(int number in numbers)
            {
                if(number % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
