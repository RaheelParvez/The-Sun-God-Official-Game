using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camthingery : MonoBehaviour
{
    public Transform wawa;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = wawa.position;
    }
}
