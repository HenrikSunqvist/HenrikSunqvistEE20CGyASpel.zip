using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hitEffect;
    public float bulletTime = 2f;
        
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            
            enemy Enemy = other.gameObject.GetComponent<enemy>();
            Enemy.TakeHit(GameObject.FindWithTag("Player").GetComponent<shooting>().damage);
            GameObject effect = Instantiate(hitEffect, transform.position, transform.rotation);
            Destroy(effect, 0.6f);
        }

        
        Destroy(gameObject);

    }
    
}
