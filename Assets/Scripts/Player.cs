using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float thrustSpeed = 1.0f;

    private Rigidbody2D _rigidBody;
    private float _turnDirection;
    private bool _thrusting;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        _thrusting = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            _turnDirection = -1.0f;
        } else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) { 
            _turnDirection = -1.0f;
        } else {
            _turnDirection = 0.0f;
        }       
    }

    private void FixedUpdate()
    {
        if (_thrusting)
        {
            _rigidBody.AddForce(this.transform.up * this.thrustSpeed);
        }
    }
}
