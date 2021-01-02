using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSand : MonoBehaviour
{
    GameObject Player;

    public LayerMask player;
    public float radius;
    public Transform Center;
    bool istouching;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        rb = Player.GetComponent<Rigidbody2D>();
  
    }

    // Update is called once per frame
    void Update()
    {
        istouching = Physics2D.OverlapCircle(Center.position, radius, player);

        void OnGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(Center.position, radius);
        }

        if (istouching)
        {
            Player.GetComponent<Movment>().speed = 2f;
            Player.GetComponent<Movment>().jumpforce = 1f;
            rb.gravityScale = 0.5f;

        }else
        {
            Player.GetComponent<Movment>().speed = 6f;
            Player.GetComponent<Movment>().jumpforce = 4f;
            rb.gravityScale = 1f;
            
        }
    }
}
