using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //飛鏢移動速度
        gameObject.transform.position+=new Vector3(-0.1f, 0, 0);
    }
}
