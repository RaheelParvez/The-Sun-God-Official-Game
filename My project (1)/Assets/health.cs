using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Health : MonoBehaviour
{
    public Image bar;
    public float bhp = 100f;
    public float damage;
    bool dead;

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Text restartText;


    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        restartText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (dead)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                string currentSceneName = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(currentSceneName);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("owww");
        if (other.gameObject.CompareTag("banana"))
        {
            Debug.Log("dmg");
            dmg(damage);
            


        }
        if (other.gameObject.CompareTag("boss"))
        {
            Debug.Log("dmg");
            dmg(damage + 25);



        }
    }


    public void dmg(float dam)
    {
        bhp -= dam;
        if (bhp < 0)
        {
            bhp = 0;
            gameOverPanel.SetActive(true);
            restartText.gameObject.SetActive(true);
            dead = true;
        }
        bar.fillAmount = bhp / 100f;
    }
    public void heal(float heal)
    {
        bhp += heal;
        if (bhp > 100) { bhp = 100; }
        bar.fillAmount = bhp / 100f;
    }
}