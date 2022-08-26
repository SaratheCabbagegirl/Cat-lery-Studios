using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource source;
    public AudioClip meow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaySound(AudioClip clip)
    {
        source.clip = clip;
        source.Play();
    }

    public void PlayMeow()
    {
        PlaySound(meow);
    }
}
