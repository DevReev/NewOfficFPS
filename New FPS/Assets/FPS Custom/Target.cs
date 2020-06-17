using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public float damaged = 10f;

    public float delay = 3f;
    public float radius = 7f;
    public float force = 700f;

    float countDown;

    public GameObject explosionEffect;

    public bool hasExploded = false;

    private void Start()
    {
        countDown = delay;
    }


    private void Update()
    {

        countDown -= Time.deltaTime;

      
    }

    public void TakeDamage(float amount)
    {
        health -= damaged;

        if (health <= 0f)
        {
            Die();

            Explode();

            /*if (!hasExploded)
            {
                Explode();

                Destroy(explosionEffect);
            }*/

        }

       
    }

    void Die()
    { 
        Destroy(gameObject);

        hasExploded = true;
    }

    void Explode()
    {
        GameObject fx = Instantiate(explosionEffect, transform.position, transform.rotation);

        hasExploded = true;

        // Get nearby objects
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider nearbyObject in colliders)
        {
            // Add force
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();

            if(rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
                
            }
        }

               Destroy(fx, 2f);
       
    }

}
