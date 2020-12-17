using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public bool onWall;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("hfa");
        onWall = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        onWall = false;
    }
}
