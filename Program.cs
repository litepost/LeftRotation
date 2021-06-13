/*
* https://www.hackerrank.com/challenges/array-left-rotation/problem
*/

using System;
using System.Collections.Generic;

namespace LeftRotation {
    class Program {
        static void Main(string[] args) {

        }

        public static List<int> rotateLeft(int d, List<int> input) {
            for (int i = 0; i < d % input.Capacity; i++) {
                input = rotateOne(input);
            }

            return input;
        }
        public static List<int> rotateOne(List<int> input) {
            int temp = input[0];
            input.RemoveAt(0);
            input.Add(temp);

            return input;
        }
    }
}
