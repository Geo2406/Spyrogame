using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;

    public GameObject KeyDoor;
    public GameObject KeyDoor2;
    public GameObject KeyDoor3;


    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 10)
        {
            Destroy(KeyDoor);
        }


        if (score == 20)
        {
            Destroy(KeyDoor2);
        }

        if (score == 35)
        {
            Destroy(KeyDoor3);
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "STARS:" + score.ToString();
    }
}
