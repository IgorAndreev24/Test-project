using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_script : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Sound_manager.Instance.PlaySound(audioClip);
            Destroy(gameObject);
        }
    }
}
