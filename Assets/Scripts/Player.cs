using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Bullet bulletPrefab;
    public float thrustSpeed = 1.0f;
    public float turnSpeed = 1.0f;

    public Transform bulletSpawnPoint;
    private Rigidbody2D _rigidBody;

    private bool _thrusting;

    private float _turnDirection;

    [SerializeField] private float invincibilityDuration = 7.0F; //respawn time is 3.0 seconds, so this - 3

    public bool isInvincible = true;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        _thrusting = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _turnDirection = 1.0f;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _turnDirection = -1.0f;
        }
        else
        {
            _turnDirection = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

    }

    private void FixedUpdate()
    {
        if (_thrusting)
        {
            _rigidBody.AddForce(-this.transform.right * this.thrustSpeed);
        }

        if (_turnDirection != 0.0f)
        {
            _rigidBody.AddTorque(_turnDirection * this.turnSpeed);
        }
    }

    private void Shoot()
    {
        Bullet bullet = Instantiate(this.bulletPrefab, this.bulletSpawnPoint.position, this.bulletSpawnPoint.rotation);
        bullet.Project(-this.bulletSpawnPoint.right);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isInvincible)
        {
            return;
        }
        if (collision.gameObject.tag == "Trash")
        {
            _rigidBody.velocity = Vector3.zero;
            _rigidBody.angularVelocity = 0.0f;

            this.gameObject.SetActive(false);

            FindObjectOfType<GameManager>().PlayerDied();
            isInvincible = true;
            Debug.Log("player invincible");
            Invoke("setInvincibilityOff", invincibilityDuration);
        }
    }

    public void setInvincibilityOff()
    {
        isInvincible = false;
        Debug.Log("player no longer invincible");
    }
}



    

    
