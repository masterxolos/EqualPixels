using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Animator m_Animator;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float movementSpeed;
    
    private int enemyNum = 2;

    private bool goingRight = true;
    private bool goingUp = true;
    
    
    void Update()
    {
        Move();
        ChangeDirection();
        ExitPacMan();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            var movement = 1f * movementSpeed * Time.deltaTime;
            transform.position += new Vector3(0, movement, 0);
            m_Animator.SetBool("goingUp",true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            var movement = -1f * movementSpeed * Time.deltaTime;
            transform.position += new Vector3(0, movement, 0);
            m_Animator.SetBool("goingUp",true);
        }
        else if (Input.GetKey(KeyCode.A)) 
        {
            var movement = -1f * movementSpeed * Time.deltaTime;
            transform.position += new Vector3(movement, 0, 0);
            m_Animator.SetBool("goingUp",false);
        }
        else if (Input.GetKey(KeyCode.D)) 
        {
            var movement = 1f * movementSpeed* Time.deltaTime;
            transform.position += new Vector3(movement, 0, 0);
            m_Animator.SetBool("goingUp",false);
        }
        else
        {
            m_Animator.SetBool("goingUp",false);
        }
        
    }
    
    private void ChangeDirection()
    {
        if (Input.GetAxis("Vertical") != 0)
        {
            if (Input.GetAxis("Vertical") < 0)
            {
                transform.localScale = new Vector3(4, -4, 4);
            }
            else if(Input.GetAxis("Vertical") > 0)
            {
                transform.localScale = new Vector3(4, 4, 4);
            }
        }
        
        else if (Input.GetAxis("Horizontal") != 0)
        {
            if (Input.GetAxis("Horizontal") < 0)
            {
                transform.localScale = new Vector3(-4, 4, 4);
            }
            else if(Input.GetAxis("Horizontal") > 0)
            {
                transform.localScale = new Vector3(4, 4, 4);
            }
        }
        
    }

    private void ExitPacMan()
    {
        if (enemyNum == 0)
        {
           Debug.Log("Enemies are finished");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            enemyNum--;
        }
    }
}
