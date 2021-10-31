using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGomo : MonoBehaviour
{
    RaycastHit hit;
    public Camera cam;
    public ChessBoard board;
    
    void Start()
    {
        this.board.init();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit))//Raycast打射線，ScreenPointToRay(Input.mousePosition)屏幕座標轉3D(滑鼠點的位置)
            {
                board.playChess((int)(hit.point.x + 0.5f), (int)(hit.point.y + 0.5f));

            }
        }
    }
}
