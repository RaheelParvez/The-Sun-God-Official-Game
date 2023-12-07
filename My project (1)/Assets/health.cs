using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public Image bar;
    public float bhp = 100f;
    public float damage;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("owww");
        if (other.gameObject.CompareTag("banana"))
        {
            Debug.Log("dmg");
            dmg(damage);
            


        }
    }


    public void dmg(float dam)
    {
        bhp -= dam;
        if (bhp < 0) { bhp = 0; }
        bar.fillAmount = bhp / 100f;
    }
    public void heal(float heal)
    {
        bhp += heal;
        if (bhp > 100) { bhp = 100; }
        bar.fillAmount = bhp / 100f;
    }
}