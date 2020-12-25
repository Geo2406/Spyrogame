using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip Waterdrop;
    static AudioSource auSrc;
    // Start is called before the first frame update
    void Start()
    {
        Waterdrop = Resources.Load<AudioClip>("Water drop");

        auSrc = GetComponent<AudioSource>();
    }


    public static void SoundPlayer(string soundplayer)
    {
        switch (soundplayer)
        {
            case "Water Drop":
                auSrc.PlayOneShot(Waterdrop);
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
