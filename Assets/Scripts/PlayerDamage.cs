using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public Rigidbody2D rb;

    public int health;
    public int maxHealth = 50;

    public static PlayerDamage instance;

    public HealthBar healthBar;
        



    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Enemy")
        {
            health -= GameObject.FindWithTag("Enemy").GetComponent<enemy>().dmg;

            healthBar.SetHealth(health);            

            if (health <= 0)
            {
                Destroy(gameObject);

            }
        }
    }



    
}
