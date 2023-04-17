using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    public GameObject muzzleFlare;

    public int damage = 1;
    public float bulletForce = 20f;
    public float bulletDelay = 1;
    float bulletNext;


    // Update is called once per frame
    void Update()
    {
        if((Input.GetButton("Fire1"))
            ||(Input.GetButton("Jump")))
        {

            Shoot();
            
        }
    }

    void Shoot()
    {
        if(Time.time > bulletNext)
        {
            bulletNext = Time.time + bulletDelay;
            GameObject bullet = Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();    
            rb.AddForce(FirePoint.up * bulletForce, ForceMode2D.Impulse);
            GameObject effect = Instantiate(muzzleFlare, transform.position, FirePoint.rotation);
            Destroy(effect, 0.4f);
            Destroy(bullet, 2f);
        }
    }
}
