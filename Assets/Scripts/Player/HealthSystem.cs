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

    private void Awake()
    {
        instance = this;
    }

}
