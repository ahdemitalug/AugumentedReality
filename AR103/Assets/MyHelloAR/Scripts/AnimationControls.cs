using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControls : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GameObject.Find("MobileMaleFree1").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void wave()
    {
        animator.SetBool("isWaving", true);
        StartCoroutine(Example());
    }


    public void walk()
    {
        animator.SetBool("isWalking", true);
        StartCoroutine(Example());
    }

    public void run()
    {
        animator.SetBool("isRunning", true);
        StartCoroutine(Example2());
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(1);
        animator.SetBool("isWaving", false);
        animator.SetBool("isWalking", false);
        animator.SetBool("isRunning", false);
        print(Time.time);
    }

    IEnumerator Example2()
    {
        print(Time.time);
        animator.transform.Translate(0, 0, 1);
        yield return new WaitForSeconds(3);
        animator.SetBool("isWaving", false);
        animator.SetBool("isWalking", false);
        animator.SetBool("isRunning", false);
        print(Time.time);
    }
}
