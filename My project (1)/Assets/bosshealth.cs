using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bossbar : MonoBehaviour
{
    public Image bar;
    public float bhp = 100f;
    public float damage;
    public GameObject boss;
    public bool oww;

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
        Debug.Log("hit");
        if (other.gameObject.CompareTag("arrow"))
        {
            dmg(damage);
            Debug.Log("dmg" + damage);
            if (oww)
            {
                boss.GetComponent<Animation>().Play("Mk_hitfFfront");
            }
            
            
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