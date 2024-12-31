using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 50;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
        _rb.linearVelocity = transform.up * speed;
        Object.Destroy(gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            if (collision.collider.GetComponent<Idamagable>() != null )
            {
                collision.gameObject.GetComponent<Idamagable>().TakeDamgae(0);
            }
        }
        Destroy(gameObject);
    }
}
