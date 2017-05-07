using System;

namespace BasicAlgorithms
{
    public static class BasicAlgoritms
    {
        public static int GCD(int n1, int n2)
        {
            if (n1 < 0 || n2 < 0)
                throw new ArgumentException();
            if (n2 == 0)
                return n1;

            int reminder = n1 % n2;
            return GCD(n2, reminder);
        }

        public static int BinarySearch(int[] array, int soughtValue)
        {
            //array should be sorted
            if (array == null)
                throw new ArgumentException();

            int lowIndex = 0;
            int highIndex = array.Length;
            while (lowIndex <= highIndex)
            {
                int midIndex = array.Length / 2;
                if (array[midIndex] == soughtValue) return midIndex;
                if (array[midIndex] < soughtValue) highIndex = midIndex - 1;
                if (array[midIndex] > soughtValue) lowIndex = midIndex + 1;
            }
            return -1;
        }

        //Binary Search with recursion and additional array
        public static int ComplicatedBinarySearch(int[] array, int soughtValue)
        {
            //array should be sorted
            if (array == null)
                throw new ArgumentException();

            int arrayLength = array.Length;
            int midIndex = arrayLength / 2;

            if (array[midIndex] == soughtValue)
                return midIndex;

            if (array[midIndex] < soughtValue)
                return ComplicatedBinarySearch(GetSubArray(array, 0, midIndex - 1), soughtValue);

            return ComplicatedBinarySearch(GetSubArray(array, midIndex, array.Length - 1), soughtValue);
        }

        private static int[] GetSubArray(int[] array, int lowIndex, int highIndex)
        {
            var resultArray = new int[highIndex - lowIndex + 1];
            for (int i = 0; i < highIndex - lowIndex + 1; i++)
            {
                resultArray[i] = array[i];
            }
            return resultArray;
        }
    }
}