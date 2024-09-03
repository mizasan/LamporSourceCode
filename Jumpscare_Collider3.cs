using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare_Collider_3 : MonoBehaviour
{
    public GameObject scaryObject3;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        scaryObject3.SetActive(true);
        audioSource.Play();
    }
}
