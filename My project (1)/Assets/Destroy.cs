using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBasic : MonoBehaviour
{ 
    void Update()
    {
     if(Input.GetKey(KeyCode.Space))
        {
            DestroyBasic(gameObject)
        }
    }
    void Update()
    {
        if (Input.GetKey(KEyCode.Space))
        {
            Destroy(other);
        }
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            DestroyBasic(GetComponent<MeshRenferer>())
        }
    }
}
