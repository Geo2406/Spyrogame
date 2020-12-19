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
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "STARS:" + score.ToString();
    }
}
