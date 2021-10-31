using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int total = 0;
        int targetGoal = 100;

        for (int i = 0; i <= targetGoal; i++)
        {
            total += i;
        }
        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
