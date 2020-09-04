using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    Animator animator;
    public Rigidbody rb;
    bool Move;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Move = false;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0f,-9.8f,0f);
        if (Move == true)
        {
            if (Input.GetKey("w"))
            {
                rb.velocity = transform.forward * 25f;
                //rb.AddForce(transform.forward * 25f);
                animator.SetBool("iswoku", true);
            }
            if (Input.GetKeyUp("w"))
            {
                animator.SetBool("iswoku", false);
            }
            if (Input.GetKey("left"))
            {
                transform.Rotate(0, -10f, 0);
            }
            if (Input.GetKey("right"))
            {
                transform.Rotate(0f, 10f, 0f);
            }
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "grand")
        {
            Move = true;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (gameObject.tag == "grand")
        {
            Move = false;
        }
    }



}
