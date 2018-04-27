using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public float speed = 10f, jumpForce = 10f;
    Rigidbody2D rb;
    float hInput = 0;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {

    }

    void move(float horizontalInput)
    {

    }

    public void startMoving(float horizontalInput){
        hInput = horizontalInput;
    }

}
