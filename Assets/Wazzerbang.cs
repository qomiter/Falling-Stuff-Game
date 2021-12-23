using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wazzerbang : MonoBehaviour
{
    [SerializeField] float gameSpeed = -1.0f; 
   
    
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0,gameSpeed,0); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= 30){
            gameSpeed = -2.0f;
            Physics.gravity = new Vector3(0,gameSpeed,0); 
        }
        if(Time.time >= 60){
            gameSpeed = -4.0f;
            Physics.gravity = new Vector3(0,gameSpeed,0); 
        }
        if(Time.time >= 90){
            gameSpeed = -8.0f;
            Physics.gravity = new Vector3(0,gameSpeed,0); 
        }
        if(Time.time >= 120){
            gameSpeed = -16.0f;
            Physics.gravity = new Vector3(0,gameSpeed,0); 
        }
        if(Time.time >= 150){
            gameSpeed = -32.0f;
            Physics.gravity = new Vector3(0,gameSpeed,0); 
        }
        if(Time.time >= 180){
            gameSpeed = -64.0f;
            Physics.gravity = new Vector3(0,gameSpeed,0); 
        }
        if(Time.time >= 210){
            gameSpeed = -128.0f;
            Physics.gravity = new Vector3(0,gameSpeed,0); 
        }
        if(Time.time >= 240){
            gameSpeed = -256.0f;
            Physics.gravity = new Vector3(0,gameSpeed,0); 
        }
        if(Time.time >= 270){
            gameSpeed = -512.0f;
            Physics.gravity = new Vector3(0,gameSpeed,0); 
        }
        
    }
}
