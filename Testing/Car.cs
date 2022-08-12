namespace StaticExample
{
    public class Car
    {
        private static int _soldNumber;
        private static int _workingNumber;
        public int Fuel = 0;

        public static void ClearCars()
        {
            _soldNumber = 0;
        }
        
        public Car()
        {
            _soldNumber += 1;
            _workingNumber += 1;
        }

        ~Car()
        {
            _workingNumber -= 1;
        }
    }
}