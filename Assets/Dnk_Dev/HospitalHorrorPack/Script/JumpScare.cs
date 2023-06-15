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

    void OnTriggerEnter () {
        Scream.Play ();
        Ghost.SetActive(true);
    }

    void OnTriggerExit () {
        Ghost.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
