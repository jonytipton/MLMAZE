using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public bool isDead = false;
    public GameObject body;

    public float speed = 6f;
    public float turnSmoothTime = .1f;
    float turnSmoothVelocity;

    public Animator anim;
    public GameObject enemyObject;

    void Update()
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

        if (body.transform.position.y >= 49f)
        {
            SceneManager.LoadScene("Title");
        }

        //testing animation:
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
        }
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
