using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingScript : MonoBehaviour
{

    public GameObject Gun;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                Gun.GetComponent<Animator>().SetTrigger("Aim");
            }
            
        }

        if (Input.GetMouseButtonUp(1))
        {
            Gun.GetComponent<Animator>().SetTrigger("New State");
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Gun.GetComponent<Animator>().SetTrigger("New State");
        }
    }
}