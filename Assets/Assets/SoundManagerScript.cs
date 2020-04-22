using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip jumpSound;
    static AudioSource audioSrc;

    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("jump");
        audioSrc = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch(clip){
            
            case "Jump":
            audioSrc.PlayOneShot(jumpSound);
            break;
        }
    }
}
