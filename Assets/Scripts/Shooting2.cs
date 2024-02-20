using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting2 : MonoBehaviour
{
   public Transform firePoint1;
   public Transform firePoint2;
   public GameObject bulletprefab;

   public float bulletForce = 10f;

   
    void Update()
    {
        
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot1();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot2();
        }
    }

    void Shoot1()
    {
        GameObject bullet = Instantiate(bulletprefab, firePoint1.position, firePoint1.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint1.up * bulletForce, ForceMode2D.Impulse);
    }

    void Shoot2()
    {
        GameObject bullet = Instantiate(bulletprefab, firePoint2.position, firePoint2.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint2.up * bulletForce, ForceMode2D.Impulse);
    }
}
