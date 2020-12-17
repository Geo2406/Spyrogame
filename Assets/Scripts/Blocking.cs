using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocking : MonoBehaviour
{

    public GameObject Player;

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
        if(Input.GetKey(KeyCode.B))
        {
            Player.GetComponent<Movment>().enabled = false;
            block.SetActive(true);
            anim.SetBool("Blocking", true);
        }
        else
        {
            Player.GetComponent<Movment>().enabled = true;
            block.SetActive(false);
            anim.SetBool("Blocking", false);
        }
    }
}
