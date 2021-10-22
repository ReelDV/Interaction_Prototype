using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubble : MonoBehaviour
{
    Rigidbody rb;
    float speed = 0.5f;
    float lifeSpan = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * (speed / 2), ForceMode.VelocityChange);
        rb.AddForce(Vector3.up * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if (lifeSpan >= 0)
        {
            lifeSpan -= Time.deltaTime;
        } else
        {
            Destroy(gameObject);
        }
    }
}
