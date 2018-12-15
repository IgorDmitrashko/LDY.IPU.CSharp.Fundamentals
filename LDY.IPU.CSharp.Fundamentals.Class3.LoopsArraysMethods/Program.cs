﻿using System;
using System.Text;

namespace LDY.IPU.CSharp.Fundamentals.Class3.LoopsArraysMethods {
    public class Program {
        internal static void Main(string[] args) {
            #region Arrays
            if (false) {
                Console.WriteLine(" --------- arrays");
                int[] firstNumberArray0 = new int[] { };
                int[] firstNumberArray = new int[4] { 1, 2, 3, 5 };
                int[] secondNumberarray = new int[] { 1, 2, 3, 5 };
                int[] thirdnumberarray = new[] { 1, 2, 3, 5 };
                int[] fourthnumberarray = { 1, 2, 3, 5 };
                int[] fifthNumberArray = new int[4];
                fifthNumberArray[0] = 1;
                fifthNumberArray[1] = 2;
                fifthNumberArray[2] = 3;
                fifthNumberArray[3] = 5;

                Console.WriteLine(fifthNumberArray[3]);  // 5
                // Console.WriteLine(fifthNumberArray[5]);  // IndexOutOfRangeException

                int[,] firstMultiDimensionalArray;
                int[,] secondMultiDimensionalArray = new int[2, 3];
                int[,] thirdMultiDimensionalArray = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
                int[,] fourthMultiDimensionalArray = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
                int[,] fifthMultiDimensionalArray = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
                int[,] sixthMultiDimensionalArray = { { 0, 1, 2 }, { 3, 4, 5 } };

                var element = sixthMultiDimensionalArray[1, 1];

                int[][] jaggedArray = new int[][]
                {
                    new int[] {1,3,5,7,9},
                    new int[] {10,2,4,6},
                    new int[] {11,22},
                    new int[] {11,22},
                    new int[] {11,22}
                };

                var elementjaggedArray = jaggedArray[3];
            }
            #endregion

            #region Loops
            if (false) {
                Console.WriteLine(" --------- Loops");
                //for
                Console.WriteLine("for");
                int[][] jaggedArray = new int[][]
                {
                    new int[] {1,3,5,7,9},
                    new int[] {0,2,4,6},
                    new int[] {11,22}
                };
                int iteratorFor = 0;
                for (int i = 0; i < jaggedArray.Length; i++) {
                    for (int j = 0; j < jaggedArray[i].Length; j++) {
                        Console.WriteLine(iteratorFor++ + ")jaggedArray[i][j] = " + jaggedArray[i][j]);
                    }
                }
                //foreach
                Console.WriteLine("foreach");
                int iteratorForeach = 0;
                foreach (var innerArray in jaggedArray) {
                    foreach (var itemArray in innerArray) {
                        Console.WriteLine(iteratorForeach++ + ") itemArray = " + itemArray);
                    }
                }

                //while
                Console.WriteLine("while");
                string exitWordWhile = "stop";
                // string inputWordWhile = string.Empty;
                string inputWordWhile = "stop";
                int iterationWhile = 0;
                while (exitWordWhile != inputWordWhile) {
                    Console.WriteLine("iteration " + iterationWhile++ + " Write something");
                    inputWordWhile = Console.ReadLine();
                    Console.WriteLine("your word is " + inputWordWhile);
                    if (exitWordWhile == inputWordWhile) {
                        Console.WriteLine(" => Good bye");
                    }
                }

                //do...while
                Console.WriteLine("do...while");
                string exitWordDoWhile = "stop";
                string inputWordDoWhile = string.Empty;
                int iterationDoWhile = 0;
                do {
                    Console.WriteLine("iteration " + iterationDoWhile++ + " Write something");
                    inputWordDoWhile = Console.ReadLine();
                    Console.WriteLine("your word is " + inputWordDoWhile);
                    if (exitWordDoWhile == inputWordDoWhile) {
                        Console.WriteLine(" => Good bye");
                    }

                } while (exitWordDoWhile != inputWordDoWhile);

            }
            #endregion

            #region Methods
            if (false) {
                Console.WriteLine(" --------- Methods");
                //void method
                SayHello();

                // return 
                string gottenHello = GetHello();
                Console.WriteLine("gottenHello = " + gottenHello);

                // pass argument
                string gottenHelloWithName = GetHelloWithName("Ivan");
                Console.WriteLine("gottenHelloWithName = " + gottenHelloWithName);

                // overload - the same name with different count of arguments
                string gottenHelloWithNames = GetHelloWithName("Ivan", "Mark");
                Console.WriteLine("gottenHelloWithNames = " + gottenHelloWithNames);

                // get recursive hello
                string gottenHellorecursive = GetHelloRecursive("Ivan");
                Console.WriteLine("gottenHellorecursive = " + gottenHellorecursive);

                //write all arguments
                WriteAllWhatYouGot("aaa", "bbb", "ccc", "ddd");

                // write array
                string[] arrayToWrite = new string[] { "aaa", "bbb", "ccc", "ddd" };
                WriteStringArray(arrayToWrite);
            }
            #endregion

            #region Strings + StringBuilder
            if (false) {
                Console.WriteLine(" --------- Strings + StringBuilder");

                StringBuilder stringBuilder = new StringBuilder("Name: ");
                Console.WriteLine("Length: {0}", stringBuilder.Length);
                Console.WriteLine("Capacity: {0}", stringBuilder.Capacity);

                stringBuilder.Append(" tutorial");
                Console.WriteLine("Length: {0}", stringBuilder.Length);
                Console.WriteLine("Capacity: {0}", stringBuilder.Capacity);

                stringBuilder.Append(" C#");
                Console.WriteLine("Length: {0}", stringBuilder.Length);
                Console.WriteLine("Capacity: {0}", stringBuilder.Capacity);

                StringBuilder stringBuilder2 = new StringBuilder("Hi dear friend");
                stringBuilder2.Append("!");
                stringBuilder2.Insert(stringBuilder2.Length, "Enjoy the world ");
                Console.WriteLine(stringBuilder2);

                stringBuilder2.Replace("world", "silence!");
                Console.WriteLine(stringBuilder2);

                stringBuilder2.Remove(3, 5);
                Console.WriteLine(stringBuilder2);

                string resultString = stringBuilder2.ToString();
                Console.WriteLine(resultString);

            };
            #endregion

            Console.ReadLine();
        }

        #region MethodsImplementation
        private static void SayHello() {
            Console.WriteLine("Hello World");
        }

        private static string GetHello() {
            return "Hello Mark";
        }

        private static string GetHelloWithName(string name) {
            return "Hello " + name;
        }

        private static string GetHelloWithName(string nameOne, string nameTwo) {
            return "Hello " + nameOne + "+" + nameTwo;
        }

        private static string GetHelloRecursive(string name) {
            if (name.Length < 20) {
                name += GetHelloRecursive(name + " " + name);
            }
            return " Hello " + name;
        }

        public static void WriteAllWhatYouGot(params string[] something) {
            Console.WriteLine("WriteAllWhatYouGot");
            for (int i = 0; i < something.Length; i++) {
                Console.WriteLine(something[i]);
            }
        }

        public static void WriteStringArray(string[] arrayToWrite) {
            Console.WriteLine("WriteStringArray");
            foreach (var item in arrayToWrite) {
                Console.WriteLine(item);
            }
        }
        #endregion

    }
}








