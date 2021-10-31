﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TicTacToe
{
    public class GameBoard : MonoBehaviour
    {
        [SerializeField]
        private Sprite black = null;
        [SerializeField]
        private Sprite white = null;
        [SerializeField]
        private Transform[] xPoints = null;
        [SerializeField]
        private Transform[] yPoints = null;
        [SerializeField]
        private GameObject chessPrefab = null;
        [SerializeField]
        private Transform objPool = null;

        private float threshold = 1.5f; //棋子與定位點需小於該值才可下

        private BoardData boardData = null;  //棋盤資料
        private ChessType curType = TicTacToe.ChessType.Empty;    // 當前棋子類型

        // 棋盤初始
        public void init()
        {
            this.boardData = new BoardData();
            this.curType = TicTacToe.ChessType.Black;  //黑先
        }

        // 執行下棋
        public void playChess(float _x, float _y)
        {
            int x = this.getXNearestPoint(_x);
            int y = this.getYNearestPoint(_y);

            if (this.boardData.checkValid(x, y))
            {
                this.dropChess(x, y);
                // 設置格子資料
                this.boardData.setData(x, y, this.curType);
                // 檢查輸贏
                // this.boardData.checkWin(x, y);
                Debug.Log("x:" + x + " " + "y" + y);
            }
        }

        // 放置棋子
        private void dropChess(int x, int y)
        {
            Vector3 pos = new Vector3(this.xPoints[x].position.x, this.yPoints[y].position.y, -1);
            GameObject obj = Instantiate(this.chessPrefab, pos, Quaternion.identity);
            obj.transform.parent = this.objPool;
            if (this.curType == ChessType.Black)
            {
                obj.GetComponent<SpriteRenderer>().sprite = this.black;
                this.curType = ChessType.White;
            }
            else
            {
                obj.GetComponent<SpriteRenderer>().sprite = this.white;
                this.curType = ChessType.Black;
            }
        }

        private int getXNearestPoint(float _x)
        {
            for (int i = 0; i < this.xPoints.Length; i++)
            {
                if (Mathf.Abs(_x - this.xPoints[i].position.x) < this.threshold)
                {
                    return i;
                }
            }
            return -1;
        }
        private int getYNearestPoint(float _y)
        {
            for (int i = 0; i < this.yPoints.Length; i++)
            {
                if (Mathf.Abs(_y - this.yPoints[i].position.y) < this.threshold)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

