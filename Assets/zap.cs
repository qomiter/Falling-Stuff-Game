using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zap : MonoBehaviour
{
    [SerializeField] float gameGravity = -1.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.gravity = new Vector3(0,gameGravity,0); 
    }
}
