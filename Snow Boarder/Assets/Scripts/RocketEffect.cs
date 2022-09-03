using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem rocketEffect;
    [SerializeField] AudioClip rocketSFX;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rocketEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(rocketSFX);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rocketEffect.Stop();
            
        }
    }
}
