using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 700f;
    public float vol = 10f;

    public AudioClip blah;
    AudioSource azip;
    // Start is called before the first frame update
    void Start()
    {
        azip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {  
            GameObject ball = Instantiate(projectile, transform.position, transform.rotation); 
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (0, launchVelocity, 0));
            Debug.Log("getting here");
            azip.Play();
            if(gameObject.name == "Projectile(Clone)"){
                Destroy(gameObject, 3f);
            }
            
        }
    }
}
