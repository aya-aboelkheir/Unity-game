using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
  public float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;
    //int wholeNumber = 3;
    //float decimalNumber = 3.45f;
    //string text = "blabla";
    //bool condition = false;
    // Start is called before the first frame update
    void Start()
    {
       rb=GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
       float horizontalInput=Input.GetAxis("Horizontal");
       float verticalInput=Input.GetAxis("Vertical");
        rb.velocity = new Vector3(horizontalInput *movementSpeed, rb.velcotiy.y, verticalInput* movementSpeed);
       
        if (Input.GetButtonDown("Jump"))
        {
           rb.velocity=new Vector3(rb.velocity.x,5f,rb.velocity.z);
        }
        //انا مكنتش شايفه فعلا في مله دي * و لا لاء ف لو نظركم جابه ابقي عدلوها 
     



    }
}
