using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Animator m_Animator;
    [SerializeField] private float movementSpeed;

    private bool goingRight = true;
    private bool goingUp = true;
    
    
    void Update()
    {
        Move();
        ChangeDirection();
    }

    private void Move()
    {
        if (Input.GetAxis("Vertical") != 0)//Y düzleminde ++ hareket
        {
            var movement = Input.GetAxis("Vertical");
            transform.position += new Vector3(0, movement, 0) * movementSpeed * Time.deltaTime;
            m_Animator.SetBool("goingUp",true);
        }
       
        else if (Input.GetAxis("Horizontal") != 0) // X düzleminde -- hareket
        {
            var movement = Input.GetAxis("Horizontal");
            transform.position += new Vector3(movement, 0, 0) * movementSpeed * Time.deltaTime;
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
}
