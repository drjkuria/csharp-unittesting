
namespace Strategy
{
    public class NumberCruncher
    {
        private readonly int[] numbers;
        private Filter filter;
        
        public NumberCruncher(Filter filter, params int[] numbers)
        {
            this.filter = filter;
            this.numbers = numbers;
        }

        public int Count()
        {
            int count = 0;
            foreach(int number in numbers)
            {
                count = filter.NumbersCount(count, number);
            }
            return count;
        }
    }
}
