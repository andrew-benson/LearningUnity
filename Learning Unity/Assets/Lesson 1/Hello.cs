using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour {

    public string yourName; // Because it's public you can see this in the Unity Inspector
    public int age = 10; // This is a private variable, so you cannot see this in the Unity Inspector

    void Start()
    {
        Debug.Log("Hello " + yourName);
        Debug.Log("Your age is " + age);
        Debug.Log("Your position is" + transform.position);
    }
}
