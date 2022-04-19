using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptalObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int value;
    {
        value += number;
    }

    public void ReplaceValue(int number)
    {
        value = number;
    }

    publicvoid DisplayImage(Image img)
    {
        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }

    private ScripObj test;

    void Start()
    {
        test = (ScriptObj) ScriptaleObject.CreatInstance(typeof(ScriptObj));

        print(testA);
        print(test.B(3));
        print(test.B(-3));
    }
}
