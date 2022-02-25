using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] cars;
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        int[] myNum = { 10, 20, 30, 40 };
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            // Outputs Volvo

            {
                string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
                cars[0] = "Opel";
                Console.WriteLine(cars[0]);
                // Now outputs Opel instead of Volvo

                {
                    string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
                    Console.WriteLine(cars.Length);
                    // Outputs 4
                }
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            foreach (type variableName in arrayName)
            {
                // code block to be executed
            }
        }
}
