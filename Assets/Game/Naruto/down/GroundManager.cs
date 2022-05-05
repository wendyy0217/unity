using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManage : MonoBehaviour
{

    readonly float top = -8;//邊界
    readonly float buttom = 8;//邊界
    //預設Y軸座標為0
    readonly float positionY = 0;
    [Range(2, 6)] public float YY;
    void Start()
    {
        //執行for迴圈「(int i = 0; i < 3; i++)」當i=0，新的座標「newGroundPositionY = initPosotionY - spacingY * i」
        //＝０-２.5*0       2.5為control裡的自設高度（spacingY）
        {
            for (int i = 0; i < 2.5; i++)
            {
                GameObject newGround = Instantiate(Resources.Load<GameObject>("floor"));
                float newGroundPositionY = positionY - YY * i;
                newGround.transform.position = new Vector3(NewGroundPositionX(), newGroundPositionY, 0);
            }
        }
        //回傳新的水平座標
        float NewGroundPositionX()
        {
            return Random.Range(top, buttom);
        }
    }
}
