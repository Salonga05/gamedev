using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image HealthBar;
    public Text WINTEXT;
   

    void Start()
    {
        maxHealth = health;
       
    }

    void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

      /* if(health = 0)
        {
            Debug.Log("Lose");
        }*/
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Win")
        {
            WINTEXT.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
