using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChessBoard : MonoBehaviour
{
    private int[,] grid;
    public Text winner = null;
    public ChessType turn { get; private set; }//可以給外部取值但不能改，只有內部可以改。
    [SerializeField]//顯示在unity inspector 裡
    private GameObject[] chessPrefabs;

    public void init()
    {
        grid = new int[15, 15];
        turn = ChessType.black;
    }

    public void playChess(int x, int y)
    {
        if (grid[x, y] != 0 || x < 0 || x > 14 || y < -1 || y > 14) return;
        Instantiate(chessPrefabs[(int)turn - 1],
        new Vector3(x, y, -1),
        Quaternion.identity);

        grid[x, y] = (int)turn;

        if (this.checkWin_a(x, y))//橫向檢查
        {
            return;
        }
        if (this.checkWin_b(x, y))//直向檢查
        {
            return;
        }
        if (this.checkWin_c(x, y))//右上左下檢查
        {
            return;
        }
        if (this.checkWin_d(x, y))//左上右下檢查
        {
            return;
        }
        if (turn == ChessType.black)
        {
            turn = ChessType.white;
        }
        else
        {
            turn = ChessType.black;
        }
    }

    //橫向檢查
    private bool checkWin_a(int x, int y)
    {
        int turn = this.grid[x, y]; //取得該位置的棋子顏色
        int count = 1;
        int i = x - 1;
        //向左檢查是否為同色棋
        while (i > 0 && i >= x - 4 && this.grid[i, y] == turn)
        {
            count += 1;
            i = i - 1;
        }
        if (count < 5)
        {
            i = x + 1;
            while (i < 15 && i <= x + 4 && this.grid[i, y] == turn)
            {
                count += 1;
                i = i + 1;
            }
        }
        // Debug.Log(count);
        if (count >= 5)
        {
            Debug.Log((ChessType)turn + " WIN");
            //winner.text="winner is"+(ChessType) turn; 
            return true;
        }
        return false;
    }
    //直向檢查
    private bool checkWin_b(int x, int y)
    {
        int turn = this.grid[x, y]; //取得該位置的棋子顏色
        int count = 1;
        int i = y - 1;
        //向下檢查是否為同色棋
        while (i > 0 && i >= y - 4 && this.grid[x, i] == turn)
        {
            count += 1;
            i = i - 1;
        }
        if (count < 5)
        {
            i = y + 1;
            while (i < 15 && i <= y + 4 && this.grid[x, i] == turn)
            {
                count += 1;
                i = i + 1;
            }
        }
        // Debug.Log(count);
        if (count >= 5)
        {
            Debug.Log((ChessType)turn + " WIN");
            return true;
        }
        return false;
    }
    //右上左下向檢查
    private bool checkWin_c(int x, int y)
    {
        int turn = this.grid[x, y]; //取得該位置的棋子顏色
        int count = 1;
        int i = x - 1;
        int j = y - 1;
        //向左下檢查是否為同色棋
        while (i > 0 && j > 0 && i >= x - 4 && j >= y - 4 && this.grid[i, j] == turn)
        {
            count += 1;
            i = i - 1;
            j = j - 1;
        }
        if (count < 5)
        {
            i = x + 1;
            j = y + 1;
            while (i < 15 && j < 15 && i <= x + 4 && j <= y + 4 && this.grid[i, j] == turn)
            {
                count += 1;
                i = i + 1;
                j = j + 1;
            }
        }
        // Debug.Log(count);
        if (count >= 5)
        {
            Debug.Log((ChessType)turn + " WIN");
            return true;
        }
        return false;
    }
    //左上右下向檢查
    private bool checkWin_d(int x, int y)
    {
        int turn = this.grid[x, y]; //取得該位置的棋子顏色
        int count = 1;
        int i = x + 1;
        int j = y - 1;

        //向右下檢查是否為同色棋
        while (i < 15 &&
            j > 0 &&
            i <= x + 4 &&
            j >= y - 4 &&
            this.grid[i, j] == turn
        )
        {
            count += 1;
            i = i + 1;
            j = j - 1;
        }
        //往左上檢查
        if (count < 5)
        {
            i = x - 1;
            j = y + 1;
            while (i > 0 && i >= x - 4 && j < 15 && j <= y + 4 && this.grid[i, j] == turn)
            {
                count += 1;
                i = i - 1;
                j = j + 1;
            }
        }
        if (count >= 5)
        {
            Debug.Log((ChessType)turn + " WIN");
            return true;
        }
        return false;
    }

    public enum ChessType
    {
        guest = 0,
        black = 1,
        white = 2
    }
}
