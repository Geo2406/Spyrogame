using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Realenemy : MonoBehaviour
{
    public GameObject EnemyParticle;

    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (lives <= 0)
        {
            Instantiate(EnemyParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }



    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Fireball")
        {
            Destroy(gameObject);
        }
    }

    public void Damage(int damage)
    {
        lives -= damage;

    }
}
