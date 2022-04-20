using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This script stores the number of fishes of Katsby
//Only one excution when tha game begins
//By Sebastian Mora
public class FishSystem : MonoBehaviour
{
    public int fishes = 0;
    public static FishSystem instance;

    private void Awake()
    {
        instance = this;
    }
}
