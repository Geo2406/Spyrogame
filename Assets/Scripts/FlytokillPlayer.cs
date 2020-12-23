using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlytokillPlayer : MonoBehaviour
{

    public float speed;
    public Transform Player;


    public float radius;
    bool istouching;
    public LayerMask player;
    public Transform center;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        istouching = Physics2D.OverlapCircle(center.position, radius, player);


        
       if(istouching)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.position, speed * Time.deltaTime);
        }
    }
}
