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

        QuickSand[] quicksand = FindObjectsOfType<QuickSand>();
        bool istouchingquicksand = false;

        for (int i = 0; i < quicksand.Length; i++)
        {
            if (quicksand[i].istouching)
            {
                istouchingquicksand = true;
                break;
            }
        }


        if (istouching)
        {
            Player.GetComponent<Movment>().speed = 1f;
            Player.GetComponent<Movment>().jumpforce = 0.5f;
            rb.gravityScale = 0.1f;

        } else if (istouchingquicksand == false)
        {
            Player.GetComponent<Movment>().speed = 6f;
            Player.GetComponent<Movment>().jumpforce = 4f;
            rb.gravityScale = 1f;
            
        }
    }
}
