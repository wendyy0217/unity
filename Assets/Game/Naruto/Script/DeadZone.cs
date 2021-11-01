using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    //如果其他的物體碰到刺
    private void OnCollisionEnter2D(Collision2D other)
    {
        //如果碰撞體的標籤為Player
        if (other.gameObject.CompareTag("Player"))
        {
            //玩家死掉
            Destroy(other.gameObject);
            Destroy(gameObject);
            Gamefuntion.Instance.GameEnd();
        }
    }
}