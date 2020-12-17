using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyblobshoot : MonoBehaviour
{
    public float speed;

    GameObject target;

    public Rigidbody2D rb;

    Vector2 MoveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").gameObject;

        MoveDirection = (target.transform.position - transform.position).normalized * speed;
        rb.velocity = new Vector2(MoveDirection.x, MoveDirection.y);


    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
    }

 
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "shield")
        {
            Destroy(gameObject);
        }
    }
   
    

}
