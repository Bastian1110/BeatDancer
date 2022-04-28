using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSystem : MonoBehaviour
{
    public int kills = 0;
    public static KillSystem instance;

    private void Awake()
    {
        instance = this;
    }

}
