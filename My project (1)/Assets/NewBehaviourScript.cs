using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
        int x = 20;
        int y = 18;
        if (x > y)
    {
          Console.WriteLine("x is greater than y");
    }
{
    int time = 20;
    if (time < 18)
    {
        Console.WriteLine("Good day.");
    }
    else
    {
        Console.WriteLine("Good evening.");
    }
    // Outputs "Good evening."
    {
        int time = 22;
        if (time < 10)
        {
            Console.WriteLine("Good morning.");
        }
        else if (time < 20)
        {
            Console.WriteLine("Good day.");
        }
        else
        {
            Console.WriteLine("Good evening.");
        }
        // Outputs "Good evening."
    }
}
// Update is called once per frame
void Update()
    {
    int time = 20;
    string result = (time < 18) ? "Good day." : "Good evening.";
    Console.WriteLine(result);
    }
}
