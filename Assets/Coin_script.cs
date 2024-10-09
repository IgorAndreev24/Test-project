using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_script : MonoBehaviour
{
    private AudioSource coinsound;
    AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        coinsound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        coinsound.Play();
        Destroy(gameObject);
    }
}
