using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        int[] array = new int[5];

        array[0] = 20;
        array[1] = 40;
        array[2] = 60;
        array[3] = 80;
        array[4] = 100;

        for (int x = 0; x < 5; x++)
        {
            Debug.Log(array[x]);
        }
        for (int x = 4; x >= 0; x--)
        {
            Debug.Log(array[x]);
        }
    }
}