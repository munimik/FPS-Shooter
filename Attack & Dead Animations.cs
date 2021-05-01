using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : TargetScript
{
    public Animator animator;
    public float health = 100;

    float coolDown = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit && coolDown <= 0)
        {
            Debug.Log("Hit");
            health -= 10;
         
            coolDown = 0.5f;

            if (health < 0)
            {
                animator.SetTrigger("Dead");
            }

            else
            {
                animator.SetTrigger("Hurt");
            }
        }
        if(coolDown > 0)
        {
            coolDown -= Time.deltaTime;
        }
    }
}
