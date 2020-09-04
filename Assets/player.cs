using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Animator animator;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.zero;
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
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "woll")
        {
            animator.SetBool("isnoboru", false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "woll")
        {
            if (Input.GetKey("space"))
            {
                rb.AddForce(transform.up * 50f);
            }
            if (Input.GetKeyDown("space"))
            {
                animator.SetBool("isnoboru", true);
            }
            if (Input.GetKeyUp("space"))
            {
                animator.SetBool("isnoboru", false);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "teki")
        {

        }
    }
}
