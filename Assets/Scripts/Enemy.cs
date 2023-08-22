using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, Idamagable
{
    public GameObject fracturedPrefab;
    public void DestroySelf()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        fracturedPrefab.active = true;
        Destroy(gameObject, 10);
    }

    public void TakeDamgae(float damage)
    {
        Debug.Log("took hit");
        DestroySelf();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public interface Idamagable
{
    public void TakeDamgae(float damage);
    public void DestroySelf();
}
