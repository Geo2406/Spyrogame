using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staligmiteandwaterdrop : MonoBehaviour
{



    public GameObject Waterdrop;


   
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("waterdrop", 0, 8);
    }

    // Update is called once per frame
    void Update()
    {
       

       
        
            
       
            
            
    }

    public void waterdrop()
    {
        Instantiate(Waterdrop, transform.position, transform.rotation);
    }
}
