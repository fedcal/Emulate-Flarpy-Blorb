using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScripts : MonoBehaviour
{
    public Rigidbody2D rigidBody2d;
    public float flapStrength;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true){
            rigidBody2d.velocity = Vector2.up * flapStrength;
        }
        
    }
}
