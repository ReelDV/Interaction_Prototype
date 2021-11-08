using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallDetection : MonoBehaviour
{
    [SerializeField]
    private UnityEvent ballCheck;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            ballCheck.Invoke();
        }
    }
}
