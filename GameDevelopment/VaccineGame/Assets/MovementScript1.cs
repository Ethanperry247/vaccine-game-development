using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool up = Input.GetButton("up" | "w");
        bool down = Input.GetButton("down" | "s");
        bool left = Input.GetButton("left" | "a");
        bool right = Input.GetButton("right" | "d");
        
    }
}
