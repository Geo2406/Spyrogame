using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPoint : MonoBehaviour
{

    public GameObject projec;
    public float originaltimetoshoot;
    float timetoshoot;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        timetoshoot = originaltimetoshoot;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && timetoshoot < 0)
        {
            shoot();
            timetoshoot = originaltimetoshoot;
            anim.SetTrigger("Shoot");
        }
        else
        {
            timetoshoot -= Time.deltaTime;
        }
    }

    void shoot()
    {
        Instantiate(projec, transform.position, Quaternion.identity); ;
    }
}
