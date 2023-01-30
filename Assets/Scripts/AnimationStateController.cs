using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    public AudioSource sword;
    public AudioSource castSpell;
    public float volume = 1.0f;


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

        if (Input.GetKey("j"))
        {
            animator.SetBool("isJumping", true);
        }

        if (!Input.GetKey("j"))
        {
            animator.SetBool("isJumping", false);
        }
        
        if (Input.GetKeyDown("space"))
        {
            animator.SetBool("isCastingSpell", true);
            castSpell.Play();

        }

        if (!Input.GetKeyDown("space"))
        {
            animator.SetBool("isCastingSpell", false);
        }

        if (Input.GetKey("z"))
        {
            animator.SetBool("isAttack", true);
            sword.Play();
        }

        if (!Input.GetKey("z"))
          animator.SetBool("isAttack", false);
        }
    }



