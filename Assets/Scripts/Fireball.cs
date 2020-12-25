using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();



        if (transform.localScale.x > 0)
        {
            rb.AddForce(new Vector2(1, 0) * speed, ForceMode2D.Impulse);
        }
        else if (transform.localScale.x < 0)
        {
            rb.AddForce(new Vector2(-1, 0) * speed, ForceMode2D.Impulse);



        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
