using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControlManager : MonoBehaviour
{
    public bool Left;
    public bool Right;
    public bool Forward;
    public bool Backward;
    public bool Space; // Jump;

    [Tooltip("Keyboard key 1 to 7")]
    public bool[] Key;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
