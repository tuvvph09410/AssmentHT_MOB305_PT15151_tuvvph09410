using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControll : MonoBehaviour
{
    public static AudioSource audioSource;
    public static AudioClip coinSound;


    // Start is called before the first frame update
    void Start()
    {

        coinSound = Resources.Load<AudioClip>("icon");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "coin":
                audioSource.PlayOneShot(coinSound);
                break;
        }
    }
}
