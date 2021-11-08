using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class ShootBubblesStudent : MonoBehaviour
{
    private XRGrabInteractable grabInteractable = null;
    [SerializeField]
    GameObject bubblePrefab;
    [SerializeField]
    Transform spawnPoint;
    private int bubbleAmmo = 10;
    [SerializeField]
    private TextMeshProUGUI ammoText;
    [SerializeField]
    InputActionReference reloadAction;
    XRBaseInteractor interactor;
    ActionBasedController actionController;
    // Start is called before the first frame update
    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(SpawnBubbles);
        reloadAction.action.started += Reload;
    }
    public void GetInteractor()
    {
        interactor = grabInteractable.selectingInteractor;
    }
    public void ReleaseInteractor()
    {
        interactor = null;
    }
    private void Reload(InputAction.CallbackContext obj)
    {
        if (obj.control.ToString().Contains("Left") && interactor.name.Contains("Left"))
        {
            bubbleAmmo = 10;
            ammoText.text = bubbleAmmo.ToString();
        }
        else if (obj.control.ToString().Contains("Right") && interactor.name.Contains("Right"))
        {
            bubbleAmmo = 10;
            ammoText.text = bubbleAmmo.ToString();
        }
    }

    private void SpawnBubbles(ActivateEventArgs arg0)
    {
        if (bubbleAmmo > 0)
        {
            Instantiate(bubblePrefab, spawnPoint.transform.position, Quaternion.identity);
            bubbleAmmo--;
            ammoText.text = bubbleAmmo.ToString();
        }
        
    }
}
