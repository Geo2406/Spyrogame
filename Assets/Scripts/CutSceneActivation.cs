using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneActivation : MonoBehaviour
{

    public GameObject CutScene1;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            CutScene1.SetActive(true);
            Time.timeScale = 0;
            text.SetActive(false);
        }
    }
}
