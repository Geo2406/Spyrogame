using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorlockmanagerForLVL2 : MonoBehaviour
{

     public int Score;
     public GameObject KeyDoor;

    

    // Start is called before the first frame update
    void Start()
    {
        Score = ScoreManager.score;



    }

    // Update is called once per frame
    void Update()
    {
        if(Score.score == 10)
        {
            Destroy(KeyDoor);
        }
    }
}
