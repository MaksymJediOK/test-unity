using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 0.5f;
    [SerializeField] float jumpHeight = 0.5f;

    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
         rbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movementVector = new Vector2(horizontalInput * movementSpeed * 100 * Time.deltaTime, rbody.velocity.y);   
        rbody.velocity = movementVector;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            movementSpeed = jumpHeight;
        }
    }
}
