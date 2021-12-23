using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlls : MonoBehaviour
{
    [SerializeField] float joyMultiplier = 3; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _x = Input.GetAxis("Horizontal") * joyMultiplier; 
        float _y = Input.GetAxis("Vertical") * joyMultiplier;
        //_x = _x + Input.mousePosition.x;
        //_y = _y + Input.mousePosition.y;
        Debug.Log(_x +" "+ _y);
        transform.position = transform.position + new Vector3(_x * joyMultiplier * Time.deltaTime,_y * joyMultiplier * Time.deltaTime, 0);

    }
}
