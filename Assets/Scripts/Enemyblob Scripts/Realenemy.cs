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
    void Update()
    {
        if(lives <= 0)
        {
            Destroy(gameObject, 0.5f);
            Instantiate(EnemyParticle, transform.position, Quaternion.identity);
        }





    }



    public void Damage(int damage)
    {
        lives -= damage;

    }
}
