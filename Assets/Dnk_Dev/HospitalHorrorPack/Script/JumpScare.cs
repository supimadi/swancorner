using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{

    public GameObject Ghost;
    public AudioSource Scream;

    void Start()
    {
        Ghost.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Ghost.SetActive(true);
            Scream.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Ghost.SetActive(false);
        }
    }

}
