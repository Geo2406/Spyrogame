using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{


    public GameObject projec;
    public float originaltimetoshoot;
    float timetoshoot;
    public Animator anim;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

        timetoshoot = originaltimetoshoot;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && timetoshoot < 0)
        {
            shoot();
            timetoshoot = originaltimetoshoot;
            anim.SetTrigger("Shoot");
        }
        else
        {
            timetoshoot -= Time.deltaTime;
        }
    }

    void shoot()
    {
        var Bullet = Instantiate(projec, transform.position, Quaternion.identity);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();

        rb.AddForce(transform.right * speed, ForceMode2D.Impulse);

        if (transform.rotation.y < 0)
        {
            Bullet.GetComponent<SpriteRenderer>().flipX = true;
        }

    }
}

