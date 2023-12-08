using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour

{
    public GameObject monkey;
    public GameObject play;
    public Transform Play;
    public float speed;
    public float turnRate;
    public Transform target;
    
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.LookAt(target);
       transform.position = Vector3.MoveTowards(transform.position, play.transform.position, speed);

    }

}
