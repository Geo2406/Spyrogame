using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeintoleveltut()
    {
        SceneManager.LoadScene(1);
    }

    public void changeintolevel1()
    {
        SceneManager.LoadScene(2);
    }

    public void changeintolevel2()
    {
        SceneManager.LoadScene(3);
    }

    public void changeintolevel3()
    {
        SceneManager.LoadScene(4);
    }
}
