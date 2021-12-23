using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(gameObject.tag == "Player")
        {
        Debug.Log("Hit");
        
        }
        else
        {
        Destroy(gameObject);
        }
    }
 }
  


