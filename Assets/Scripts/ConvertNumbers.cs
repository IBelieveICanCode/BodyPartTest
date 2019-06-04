using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvertNumbers : MonoBehaviour
{
    public InputField inputNumbers;
    private static List<int> convertedNumbers = new List<int>();

    public static List<int> ConvertedNumbers { get => convertedNumbers; set => convertedNumbers = value; }

    public void Convert()
    {
        int numbers = int.Parse(inputNumbers.text);
        while (numbers > 0)
        {
            ConvertedNumbers.Add(numbers % 10);
            numbers /= 10;
        }
        ConvertedNumbers.Reverse();
    }
}
