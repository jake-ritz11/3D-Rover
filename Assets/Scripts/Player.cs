using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController characterController;
    public float speed;
    public float gravity = -9.81f;
    public Vector3 Velocity;
    public Animator anim;
    public float turnStrength = 45;

    private void Update()
    {
        if ( characterController.isGrounded && Velocity.y < 0)
        {
            Velocity.y = 0;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, x * turnStrength * Time.deltaTime, 0f));
        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);

        Velocity.y += gravity * Time.deltaTime;
        characterController.Move(Velocity * Time.deltaTime);
    }
}
