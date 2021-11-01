using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public Gamefuntion exploe;
    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {
        //飛鏢移動速度
        gameObject.transform.position += new Vector3(-0.1f, 0, 0);
    }
    // 飛鏢碰到玩家或子彈會消失
    void OnTriggerEnter2D(Collider2D col)
    { 
        if (col.tag == "missile")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
           Gamefuntion.Instance.AddScore();
            

        }
        if (col.tag == "Player")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
           Gamefuntion.Instance.GameEnd(); 

        }
    }
}
