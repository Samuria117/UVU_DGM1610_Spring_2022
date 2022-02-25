using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (statement 1; statement 2; statement 3)
            {
            // code block to be executed
        }
         
        for (int i = 0; i <5; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i <= 10; i = i + 2)

        {
            Console.WriteLine(i);
        }

        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
    }
}