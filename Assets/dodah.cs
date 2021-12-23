using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dodah : MonoBehaviour
{
    public static int gameScore = 0; 
    // Start is called before the first frame update
    void Start()
    {
        gameScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnGUI(){ 
        GUI.Box (new Rect (100, 20, 50,20), gameScore.ToString());
        
    }
}
