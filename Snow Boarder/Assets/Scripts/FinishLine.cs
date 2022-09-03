using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float DelayAmount=1f;
    [SerializeField] ParticleSystem FinishEffect;
    private void OnTriggerEnter2D(Collider2D other) {
         if(other.tag==("Player")){
            GetComponent<AudioSource>().Play();
            FinishEffect.Play();
            Invoke("ReloadScene", DelayAmount);
        }
    }
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
