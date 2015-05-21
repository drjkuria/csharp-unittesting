
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
            return 0;
        }
    }
}
