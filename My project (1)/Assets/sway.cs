using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sway : MonoBehaviour
{
    public float smooth;
    public float mult;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MX = Input.GetAxisRaw("Mouse X") * mult;
        float MY = Input.GetAxisRaw("Mouse Y") * mult;

        Quaternion RX = Quaternion.AngleAxis(-MY, Vector3.right);
        Quaternion RY = Quaternion.AngleAxis(-MX, Vector3.up);

        Quaternion TR = RX * RY;

        transform.localRotation = Quaternion.Slerp(transform.localRotation, TR, smooth * Time.deltaTime);
    }
}
