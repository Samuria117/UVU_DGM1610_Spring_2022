using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
    void Start()
    {
      static void Main(string[] args)
        {
            int x = 100 + 50;
            Console.WriteLine(x);

            {
                int sum1 = 100 + 50;        // 150 (100 + 50)
                int sum2 = sum1 + 250;      // 400 (150 + 250)
                int sum3 = sum2 + sum2;     // 800 (400 + 400)
                {
                    int x = 10;
                    x += 5;
                    {
                        static void Main(string[] args)
                        {
                            int x = 5;
                            int y = 3;
                            Console.WriteLine(x == y);  // returns False because 5 is not equal to 3
                            {
                                static void Main(string[] args)
                                {
                                    int x = 5;
                                    int y = 3;
                                    Console.WriteLine(x < y); // returns False because 5 is not less than 3
                                }
                            }
                        }
                }
            }
        }
    }

}
