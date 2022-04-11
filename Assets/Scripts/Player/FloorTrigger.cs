using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to detect if paleyer is in the floor
//By Sebastian Mora
public class FloorTrigger : MonoBehaviour
{
    public static bool grounded = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        grounded = true;
        print("Esta en el piso");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
        print("Esta en el aire");
    }
}
