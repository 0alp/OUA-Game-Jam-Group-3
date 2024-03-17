using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static bool ThereIsKey = false;

    public void CollectKey()
    {
        ThereIsKey = true;
    }

    public bool IsThereKey()
    {
        return ThereIsKey;
    }
}
