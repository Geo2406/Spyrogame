using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterdrop2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 6f);
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Spike")
        {
            Destroy(gameObject);
        }


        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
