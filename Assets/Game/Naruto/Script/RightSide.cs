using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // 子彈碰到右邊之後消失
    void Update()
    {
        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "missile"||col.tag=="Player")
            {
                Destroy(col.gameObject);
                
            }
        }
    }
}

