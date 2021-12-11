using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollapsingPlat : MonoBehaviour
{
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Invoke("DropPlate", 0.3f);
            Destroy(gameObject, 1.2f);
        }
    }
    void DropPlat()
    {
        rb.isKinematic = false;
    }
}
