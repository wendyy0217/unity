using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
     public float BackgroundMoveSpeed=4f;//背景移動速度
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left*BackgroundMoveSpeed*Time.deltaTime);//*Time.deltaTime每秒調用這段程式碼讓他朝右移動
        Vector3 position= this.transform.position;//獲取物體當前座標
        if(position.x<=-34.3f)
        {
            this.transform.position= new Vector3(position.x+34.3f*2,position.y,position.z);
        }
    }
}