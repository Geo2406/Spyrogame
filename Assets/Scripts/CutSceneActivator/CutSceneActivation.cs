﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



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
            
            text.SetActive(false);
            

              
            
               
            
        }
    }

    public void nextlevel()
    {
        SceneManager.LoadScene(3);
    }

    public void nextleveltutorial()
    {
        SceneManager.LoadScene(1);



    }



    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
