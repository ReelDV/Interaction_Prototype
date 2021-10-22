using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RemoteActivate : MonoBehaviour
{
    [SerializeField]
    GameObject Green;
    private XRGrabInteractable grabInteractable;
    // Start is called before the first frame update
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(TVOn);
    }

    private void TVOn(ActivateEventArgs arg0)
    {
        Green.SetActive(true);

    }

}
