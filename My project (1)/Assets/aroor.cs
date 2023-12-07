    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aroor : MonoBehaviour
{
    public GameObject arr;
    public GameObject platt;
    public ParticleSystem system;
    public int weee;
    public float off;
    public float offy;
    float timer;
    float holdDur = 1f;
    private bool ready;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            timer = Time.time;
        }
        else if (Input.GetMouseButton(0))
        {
            if (Time.time - timer > holdDur)
            {
               
                timer = float.PositiveInfinity;
                Debug.Log("ready");
                ready = true;
                system.Play();


            }
        }
        else
        {
            timer = float.PositiveInfinity;
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (ready == true)
            {
                Fire();
            }
            ready = false;
            system.Stop();
        }
      

    }
    void Fire()
    {
        GameObject naw = Instantiate(arr) as GameObject;
        Vector3 high = platt.transform.position;
        high += Camera.main.transform.forward * off;
        high.y += offy;
        naw.transform.position = high;
        Rigidbody rb = naw.GetComponent<Rigidbody>();
        rb.velocity = Camera.main.transform.forward * weee;
    }
}
