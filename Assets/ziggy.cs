using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ziggy : MonoBehaviour
{
    public AudioClip impact2;
    public float vol = 0.5f;
    
    AudioSource audioSource2;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        audioSource2.Play();
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
