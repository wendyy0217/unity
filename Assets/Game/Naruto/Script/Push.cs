using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float PushMoveSpeed =4f;//背景移動速度
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left*PushMoveSpeed*Time.deltaTime);//往左移動背景
        Vector3 position =this.transform.position;//獲取物體適當座標
        if(position.x<=-26f)
        {
            this.transform.position=new Vector3(position.x+26f*2,position.y,position.z);
        //26f*2是圖片要移兩個圖片的長度才會回到原點
        }
    }
}
