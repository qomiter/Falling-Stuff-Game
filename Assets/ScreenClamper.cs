using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenClamper : MonoBehaviour
{   
    public Camera MainCamera; //be sure to assign this in the inspector to your main camera
    [SerializeField] private Vector2 screenBounds;


    // Use this for initialization
    void Start(){
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));

    }

    // Update is called once per frame
    void LateUpdate(){
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 , screenBounds.x);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 , screenBounds.y);
        transform.position = viewPos;
    }
}