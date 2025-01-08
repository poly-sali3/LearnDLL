namespace LearnDLL
{
    public class MainClass
    {
        private int _value;

        
        public MainClass(int value)
        {
            if (value < 0 || value > 255)
            {
                throw new Exception( "Значение должно быть от 0 до 255");
            }
            _value = value;
        }

        
        public int GetDifference(int inputValue)
        {
            if (inputValue < 0 || inputValue > 255)
            {
                return 0;
            }
            return Math.Abs(inputValue - _value);
        }

    }
}
