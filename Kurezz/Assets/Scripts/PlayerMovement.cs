using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Vector2 velocity;
    private Rigidbody2D rig;
    private float jumpSpeed = 5;
    private float jumpVelocity = 20;
    private float playerSpeed = 25;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();

    }


    //bttn movement
    public void jumpButton()
    {
        rig.velocity = Vector2.up * jumpSpeed;
        velocity.y = jumpVelocity;

        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed);

    }

    public void slideButton()
    {
        //'ll work on this later
    }


}