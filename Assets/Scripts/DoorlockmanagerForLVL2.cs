using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorlockmanagerForLVL2 : MonoBehaviour
{

    ScoreManager Score;
    public GameObject KeyDoor;



    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<ScoreManager>();
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
