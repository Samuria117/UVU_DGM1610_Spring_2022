using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiviatingGameObjects : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        Debug.Log("Active Self:" + myObject.activeSelf)
        Debug.Log("Activve in Hierarchy" + myObjecct.activeInHierarchy);
    }
}
