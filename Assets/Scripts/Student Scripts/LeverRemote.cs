using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverRemote : MonoBehaviour
{
    private HingeJoint hinge;
    [SerializeField]
    GameObject Remote;  //Calling for use of remote spawn
    // Start is called before the first frame update
    void Start()
    {
        hinge = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hinge.angle == hinge.limits.max)    //Sets remote to appear once lever is pulled down and activates the max numeral on hinge joint
        {
            Remote.SetActive(true);
        }
    }
}
