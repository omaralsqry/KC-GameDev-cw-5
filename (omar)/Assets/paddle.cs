using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    Rigidbody2D RB;

    float playerInput;

    int speed=7;

    // Start is called before the first frame update
    void Start()
    {
          RB = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
       playerInput = Input.GetAxis("Horizontal");
       RB.velocity = new Vector2(playerInput * speed,0);
    }
}
