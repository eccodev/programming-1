using System;
using System.Linq;
using UnityEngine;

public class Homework7 : MonoBehaviour
{
    void Start()
    {
        float[] numbers = { 4.4f, 7.7f, 2.2f, 3.3f, 6.6f, 9.9f, 8.8f }; // An array of Unity coordinates called `numbers`

        float highest = numbers.Max(); // The value of `highest` will become the result of `numbers.Max` in the `for` loop below
        float lowest = numbers.Min(); // The value of `lowest` will become the result of `numbers.Min` in the `for` loop below

        int highestIndex = Array.IndexOf(numbers, highest); //Gathering the index of the `highest` value in the `numbers` array
        int lowestIndex = Array.IndexOf(numbers, lowest); // And the `lowest` index of `numbers`

        for (int i = 0; i < numbers.Length; i++) // if `i` is less than `numbers.Length` (how long the array `numbers` is), loop and add 1 to `i`
        {
            if (numbers[i] > highest) // If `i` is greater than `numbers.Max` (the highest value in the array `numbers`), do:
            {
                highest = numbers[i]; // Setting `highest` to equal the highest number in the array, which is currently `i`
                highestIndex = i; // Setting `highestIndex` to the value of `i`, which is the index with the highest number in the array
            }
            if (numbers[i] < lowest) // If `i` is less than `numbers.Min` (the lowest value in the array `numbers`), do:
            {
                lowest = numbers[i]; // Setting `lowest` to equal the lowest number in the array, which is currently `i`
                lowestIndex = i; // Setting `lowestIndex` to the value of `i`, which is the index of `i` right now
            }
        }

        Debug.Log("Highest number: " + highest); // Log the highest number
        Debug.Log("Lowest number: " + lowest); // Log the lowest number
        Debug.Log("Highest number index: " + highestIndex); // Log the index of the highest number
        Debug.Log("Lowest number index: " + lowestIndex); // Log the index of the lowest number
    }
}
// p.s. big props to my pal Pdawg for teaching me how to use `array.Max()` and `.Min()` instead of trying to determine each value in the array as a float and using `float.MaxValue` and `.MinValue`, and that you can just use `Array.IndexOf` to determine the index of a variable in an array. 