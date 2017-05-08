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
            int highIndex = array.Length - 1;
            while (lowIndex <= highIndex)
            {
                int midIndex = lowIndex + (highIndex - lowIndex) / 2;
                if (array[midIndex] == soughtValue) return midIndex;
                if (array[midIndex] < soughtValue) lowIndex = midIndex + 1;
                if (array[midIndex] > soughtValue) highIndex = midIndex - 1;
            }
            return -1;
        }

        private static int[] GetSubArray(int[] array, int lowIndex, int highIndex)
        {
            var resultArray = new int[highIndex - lowIndex + 1];
            for (int i = 0; i < highIndex - lowIndex + 1; i++)
            {
                resultArray[i] = array[lowIndex + i];
            }
            return resultArray;
        }
    }
}