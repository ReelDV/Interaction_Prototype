using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System;

public class ToggleLocomoation : MonoBehaviour
{
    [SerializeField]
    TeleportationProvider tpProvider;
    [SerializeField]
    ActionBasedContinuousMoveProvider conProvider;
    [SerializeField]
    InputActionReference toggleLocomoation;

    public UnityEvent allowContinous;
    public UnityEvent allowTeleport;
    // Start is called before the first frame update
    void Awake()
    {
        toggleLocomoation.action.started += ToggleLoco;
        
    }
    private void Start()
    {
        tpProvider = GameObject.Find("XR Rig 1").GetComponent<TeleportationProvider>();
    }

    private void ToggleLoco(InputAction.CallbackContext obj)
    {
        bool tp = tpProvider.enabled;
        if (tp)
        {
            AllowContinous();
        } else
        {
            AllowTeleport();
        }

    }
    void AllowContinous()
    {
        allowContinous.Invoke();
    }
    void AllowTeleport()
    {
        allowTeleport.Invoke();
    }
}
