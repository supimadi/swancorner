using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class GrabSword : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject dagger;

    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
        
    }

    public void FireBullet(ActivateEventArgs arg){
        Destroy(dagger);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
