using UnityEngine;

public class SC_HeadBobber : MonoBehaviour
{
    public float walkingBobbingSpeed = 13f;
    public float bobbingAmount = 0.01f;
    public bool moving;
    public bool sprinting;

    float defaultPosY = 0;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        defaultPosY = transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s")|| Input.GetKey("d"))
        {
            moving = true;
        }
        else { moving = false; }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            bobbingAmount += 0.02f;
            walkingBobbingSpeed += 4f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            bobbingAmount -= 0.02f;
            walkingBobbingSpeed -= 4f;
        }
        if (moving)
        {
            //Player is moving
            timer += Time.deltaTime * walkingBobbingSpeed;
            transform.localPosition = new Vector3(transform.localPosition.x, defaultPosY + Mathf.Sin(timer) * bobbingAmount, transform.localPosition.z);
        }
        else
        {
            //Idle
            timer = 0;
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.Lerp(transform.localPosition.y, defaultPosY, Time.deltaTime * walkingBobbingSpeed), transform.localPosition.z);
        }
    }
}