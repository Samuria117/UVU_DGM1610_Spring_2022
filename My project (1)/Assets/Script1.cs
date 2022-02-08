using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Iput.GetKeyDown(KeyCode.g))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Iput.GetKeyDown(KeyCode.g))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }

