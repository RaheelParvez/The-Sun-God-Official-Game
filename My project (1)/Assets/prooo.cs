using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prooo : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(rb.velocity) * Quaternion.AngleAxis(270, Vector3.right);
    }
}
