using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Collider : MonoBehaviour
{
    public GameObject targetObject;
    private void OnTriggerEnter(Collider other)
    {
        targetObject.SetActive(true);
    }
}
