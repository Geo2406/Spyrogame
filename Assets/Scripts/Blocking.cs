using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocking : MonoBehaviour
{

     GameObject Player;

    public GameObject block;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            Player.GetComponent<Movment>().speed = 0; 
            block.SetActive(true);
            anim.SetBool("Blocking", true);
        }
        else if(Input.GetKeyUp(KeyCode.B))
        {
            Player.GetComponent<Movment>().speed = 6;
            block.SetActive(false);
            anim.SetBool("Blocking", false);
        }
    }
}
