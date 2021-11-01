using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // 子彈射出的方向與速度
    void Update()
    {
        gameObject.transform.position += new Vector3(2f,0, 0);

    }

}
