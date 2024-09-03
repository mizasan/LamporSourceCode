using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Musik_Hutan : MonoBehaviour
{
    public static Musik_Hutan instance;
 
    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}