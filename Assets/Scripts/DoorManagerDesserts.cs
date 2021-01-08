using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManagerDesserts : MonoBehaviour
{


    public int Score;
    public GameObject keydoor;
    public GameObject keydoor1;

    // Start is called before the first frame update
    void Start()
    {
        Score = ScoreManager.instance.score;
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreManager.instance.score == 40)
        {
            keydoor.SetActive(true);
        }

        if (ScoreManager.instance.score == 55)
        {
            keydoor1.SetActive(true);
        }
    }
}
