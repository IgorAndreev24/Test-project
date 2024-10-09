using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_input : InteractSystem
{
    Transform player_transform;

    [SerializeField]
    private float player_speed = 0.5f;
    Rigidbody rb;

    Vector3 movement;
    float horizontalMove;
    float verticalMove;
    public new GameObject camera;
    private Vector3 rotationY;
    float jumpAmount = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        MyInput();

        //jump
        if (Input.GetKeyDown(KeyCode.Space) && isGround())
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        }
    }

    private void MyInput()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");

        movement =  camera.transform.forward * verticalMove + camera.transform.right * horizontalMove;
        movement *= player_speed;
        movement = Vector3.ClampMagnitude(movement, player_speed);
        movement.y = rb.velocity.y;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        rb.velocity = movement;
    }

}
