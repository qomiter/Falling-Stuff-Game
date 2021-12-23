using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zing : MonoBehaviour
{
    public AudioClip impact;
    public float vol = 0.5f;
    
    AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        audioSource.Play();
        if(gameObject.name == "Cube(Clone)" || col.gameObject.name == "Projectile(Clone)" || col.gameObject.name == "mine(Clone)")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            dodah.gameScore += 1; 
            Destroy(gameObject, 5f);
            if(col.gameObject.tag == "Bullet" || col.gameObject.name == "mine(Clone)"){
                Destroy(col.gameObject);
            }
            else{return;}
            
        }
        
    }
}