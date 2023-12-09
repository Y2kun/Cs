using System;

namespace sortingAlgorithm {
    public class Programm {
        const int LENGTH = 500;
        static void Main(string[] args) {
            foreach (var item in BubbleSort(RandomNumber())) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] BubbleSort(int[] array) {    
            for (int i = 0; i < LENGTH - 1; i++) {
                for (int j = 0; j < LENGTH - i - 1; j++) {
                    if (array[j] > array[j + 1]) {
                        array[j] = array[j + 1];
                        array[j + 1] = array[j];
                    }
                }
            }
            return array;
        }

        static int[] RandomNumber() {
            Random rnd = new Random();
            int[] input = new int[LENGTH];
            for(int i = 0; i < LENGTH; i++) {
                input[i] = rnd.Next(1, 1000);
            }
            return input;
        }
    }   
}