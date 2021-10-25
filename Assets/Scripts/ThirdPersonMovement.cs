using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    //Handles Player Movement

    public CharacterController controller;
    public Transform cam;
    public bool isDead = false;

    public float speed = 6f;
    public float turnSmoothTime = .1f;
    float turnSmoothVelocity;

    public Animator anim;
    public GameObject enemyObject;

    void Update() //Actual movement
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDirection.normalized * speed * Time.deltaTime);
        }

        

        //Animates Player
        if (isDead == false)
        {
            if (direction.magnitude > 0f)
            {
                anim.SetTrigger("isMoving");
            }
            if (direction.magnitude <= 0f)
            {
                anim.SetTrigger("isIdle");
            }
        } // The death animation doesn't really work...
        while (isDead == true)
        {
            anim.SetTrigger("isDead");
            Debug.Log("dead");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 10) //did it hit any enemy
        {
            isDead = true;            
        }
    }
}
