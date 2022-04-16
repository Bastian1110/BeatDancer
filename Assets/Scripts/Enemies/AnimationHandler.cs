using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script to chamge the animations of an enemy
//By Sebastian Mora
public class AnimationHandler : MonoBehaviour
{
    private Animator animator;
    private Transform trans;

    public bool moving;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        trans = GetComponent<Transform>();   
    }

    private IEnumerator ItsMoving()
    {
        float start = trans.position.x;
        yield return new WaitForSeconds(0.01f);
        float end = trans.position.x;
        if(start == end)
        {
            moving = false;
        }
        else
        {
            moving = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ItsMoving());
        animator.SetBool("IsMoving",moving);
    }
}
