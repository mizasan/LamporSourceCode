using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare_Collider : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject scaryObject;

    private void OnTriggerEnter(Collider other)
    {
        scaryObject.SetActive(true);
        audioSource.Play();
    }
}
