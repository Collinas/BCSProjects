using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float turnSpeed = 0.5f;
    [SerializeField] float moveSpeed = 1.0f;
    [SerializeField] float slowSpeed = 5f;
    [SerializeField] float boostSpeed = 50f;

    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);

        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);

        float clampedX = Mathf.Clamp(transform.position.x, -70, 70);
        float clampedY = Mathf.Clamp(transform.position.y, - 50, 50);
        transform.position = new Vector3(clampedX, clampedY, transform.position.z);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Player collided with obstacle");
            moveSpeed = slowSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.CompareTag("Boost"))
        {
            moveSpeed = boostSpeed;
        }
    }
}
