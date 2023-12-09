namespace arrayOfMultiples {
    public class Program {
        public static void ArrayOfMultiples(int x, int y) {
            for (int i = 1; i <= y; i++) {
                Console.WriteLine("#" + i + ": " + x * i);
            }
            Console.WriteLine("////////////////////////////////////");
        }

        static void Main(string[] args) {
            ArrayOfMultiples(7, 5);
            ArrayOfMultiples(12, 10);
            ArrayOfMultiples(17, 6);
        }
    }
}