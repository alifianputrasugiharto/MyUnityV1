using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salah : MonoBehaviour
{
    public AudioClip PopSound;
    public AudioSource source;

    void Start()
    {
        AudioSource source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col){
        score.book1A -=10;
        
        
        Destroy (gameObject);
         source.PlayOneShot(PopSound);
    }
}
    

    