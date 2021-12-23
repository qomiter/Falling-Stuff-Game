using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] public float movementSpeed = 25f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float leftNRight = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float upNDown = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;  
        transform.Translate(leftNRight, upNDown, 0);
    }
}
