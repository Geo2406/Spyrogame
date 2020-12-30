using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookActivator : MonoBehaviour
{

    public GameObject page;
    bool ischecked;
    public float radius;
    public LayerMask Player;
    public Transform PageActivator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ischecked = Physics2D.OverlapCircle(PageActivator.position, radius, Player);


        if(ischecked)
        {
            page.SetActive(true);
        }else
        {
            page.SetActive(false);
        }
    }
}
