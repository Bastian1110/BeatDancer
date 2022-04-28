using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadHandler : MonoBehaviour
{
    public Renderer render;
    public bool kill = false;

    private void Start()
    {
        render = GetComponent<Renderer>();
        Wait();
    }

    void Update()
    {
        if (kill)
        {
            if (!render.isVisible)
            {
                HealthSystem.instance.health = -1;
            }

        }
    }

    void Wait()
    {
        StartCoroutine(HandleWait());
    }

    IEnumerator HandleWait()
    {
        yield return new WaitForSeconds(1f);
        kill = true;
    }
}
