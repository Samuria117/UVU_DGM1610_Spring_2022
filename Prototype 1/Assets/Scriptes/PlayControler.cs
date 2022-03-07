using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        transfrom.Translate(0, 0, 1);
    }
}
