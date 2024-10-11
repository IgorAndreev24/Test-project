using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_manager : MonoBehaviour
{
    private AudioSource Audio_Source;

    public static Sound_manager Instance = null;

    private void Start()
    {
        Audio_Source = GetComponent<AudioSource>(); 
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

    }

    public void PlaySound(AudioClip audioClip)
    {
        Audio_Source.clip = audioClip;
        Audio_Source.Play();
    }
}
