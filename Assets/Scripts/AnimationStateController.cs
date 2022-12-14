using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log("Animator component loaded");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            animator.SetBool("isRunning", true);
            Debug.Log("Run forest, run!");
        }
        if (!Input.GetKey("up"))
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKey("down"))
        {
            animator.SetBool("isBackward", true);
        }
        if (!Input.GetKey("down"))
        {
            animator.SetBool("isBackward", false);
        }

        if (Input.GetKey("space"))
        {
            animator.SetBool("isJumping", true);
        }

        if (!Input.GetKey("space"))
        {
            animator.SetBool("isJumping", false);
        }
    }
}


