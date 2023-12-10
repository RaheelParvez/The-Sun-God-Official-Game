using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nobanana : MonoBehaviour
{
    bool kill;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (kill)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (!other.gameObject.CompareTag("boss"))
        {
            kill = true;
        }
    }
}