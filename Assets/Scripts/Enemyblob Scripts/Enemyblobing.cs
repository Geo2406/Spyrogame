using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyblobing : MonoBehaviour
{



    public GameObject Bullet;

    public float firerate;
    float nextfire;

    bool detected;

    // Start is called before the first frame update
    void Start()
    {
        nextfire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(detected)
        {
            nextfire -= Time.deltaTime;

            if(nextfire < 0)
            {
                Shoot();
                nextfire = firerate;
               


            }

        }

       

    }
    
   

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Shoot();
            detected = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Shoot();
            detected = false; 
        }
    }

    void Shoot()
    {
       
        
            Instantiate(Bullet, transform.position, Quaternion.identity);
        


    }

   
}
