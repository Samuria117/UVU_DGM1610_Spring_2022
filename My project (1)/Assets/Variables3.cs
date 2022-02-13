using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables3 : MonoBehaviour
{
    int myNum
    {
        myNum = 15;
        Console.WriteLine(myNum);

        int myNum = 15;

    myNum = 20; // myNum is now 20
        Console.WriteLine(myNum);

        int myNum = 5;               // Integer (whole number)
    double myDoubleNum = 5.99D;  // Floating point number
    char myLetter = 'D';         // Character
    bool myBool = true;          // Boolean
    string myText = "Hello";     // String

    float f1 = 35e3F;
    double d1 = 12E4D;
    Console.WriteLine(f1);
    Console.WriteLine(d1);
   }
}