using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    // 1
    public float onscreenDelay = 3f;
    public GameObject SpellExplosion; 
    public 

    void Start()
    {
        // 2
        Destroy(this.gameObject, onscreenDelay);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(this.gameObject);
            GameObject explode = Instantiate(SpellExplosion, transform.position, Quaternion.identity);
            explode.GetComponent<ParticleSystem>().Play();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Enemy")
        {
            Destroy(this.gameObject);
        }

    }

}