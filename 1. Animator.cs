using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : TargetScript
{
    public Animator animator;
    public float health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isHit)
        {
            Debug.Log("Hit");
            animator.SetTrigger("Hurt");
            health -= 10;

        }
    }
}
