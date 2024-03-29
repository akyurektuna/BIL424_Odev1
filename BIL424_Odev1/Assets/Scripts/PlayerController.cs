using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    Vector3 velocity;

    //gravity checks
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //checking if sphere is colliding for gravity increase
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y <0)
            velocity.y = -2f;
        

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //player's local directions
        Vector3 move = transform.right*x+transform.forward*z;
        controller.Move(move*speed*Time.deltaTime);
        if(Input.GetButtonDown("Jump") && isGrounded)
            velocity.y = Mathf.Sqrt(jumpHeight*-2f*gravity);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "StartPoint")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("yasandi bisi");
        }
    }
}
