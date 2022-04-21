using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This script stores the health of Katsby
//Only one excution when tha game begins
//By Sebastian Mora
public class HealthSystem : MonoBehaviour
{
    public float health = 1;
    public static HealthSystem instance;

    Animator anim;

    private void Awake()
    {
        instance = this;
        anim = GetComponent<Animator>();
    }

    public void DamageAnimation()
    {
        StartCoroutine(DamageAnimationHandler());
    }

    IEnumerator DamageAnimationHandler()
    {
        anim.SetBool("isDamage", true);
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("isDamage", false);
    }

    public void KatsbyDeath()
    {
        Destroy(gameObject, 0.5f);
    }
}
