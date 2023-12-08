using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bananaShoot : MonoBehaviour
{
    public GameObject banana;
    public GameObject player;
    public int speed;
    float timer;
    float holdDur = 1f;
    public int bana = 200;
    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Time.time - timer > holdDur)
        {
            BANANA();
            timer = Time.time;
            
        }


    }

    void BANANA()
    {
        GameObject obj = Instantiate(banana) as GameObject;
        Vector3 better = transform.position;
        better.y += 6f;
        obj.transform.position = better;
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        Vector3 play = player.transform.position;
        play.y -= 6;
        Vector3 dic = play - transform.position;
        rb.velocity = dic * speed;
    }
}
