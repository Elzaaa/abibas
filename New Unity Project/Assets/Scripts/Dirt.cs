using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{

    public GameObject hiteffect;

    public void Update()
    {
        Physics2D.IgnoreLayerCollision(8, 9);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hiteffect, transform.position, Quaternion.identity);
        Destroy(effect,1f);
        Destroy(gameObject);
    }
}
