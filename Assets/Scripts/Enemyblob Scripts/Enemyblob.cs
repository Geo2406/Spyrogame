using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyblob : MonoBehaviour
{
    public Transform Player;
    

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 direction = Player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle + 70, Vector3.forward);
        transform.rotation = rotation;



    }


   
    

}
