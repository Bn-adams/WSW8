using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playetController : MonoBehaviour
{
    Rigidbody rb;
    public int moveSpeed;
    private float horizontalInput;
    private float verticalInput;   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MyInput();
        Movement();
        
    }
    public void MyInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput  = Input.GetAxis("Vertical");
    }
    public void Movement()
    {
        rb.velocity = new Vector3(horizontalInput * moveSpeed, rb.velocity.y, verticalInput * moveSpeed);
    }
}
