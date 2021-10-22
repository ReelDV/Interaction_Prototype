using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BubbleShooting : MonoBehaviour
{
    [SerializeField]
    GameObject bubblePrefab;
    private XRGrabInteractable grabInteractable;
    [SerializeField]
    GameObject spawnPoint;
    // Start is called before the first frame update
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(FireBubbles);
    }

    private void FireBubbles(ActivateEventArgs arg0)
    {
        Instantiate(bubblePrefab, spawnPoint.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
