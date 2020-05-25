namespace Statisch01
{
    public class Counter
    {
        public int count;

        public Counter()
        {
            count = 0;
        }

        public int Add()
        {
            count++;
            return count;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="factor"></param>
        /// <returns>reference to self</returns>
        public Counter Multiply(int factor)
        {
            count *= factor;
            return this;
        }
    }
}