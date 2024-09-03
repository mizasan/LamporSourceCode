using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare_Collider_2 : MonoBehaviour
{
    public GameObject scaryObject2;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        scaryObject2.SetActive(true);
        audioSource.Play();
    }
}
