using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BiggerCards : MonoBehaviour
{
    ///enum=枚舉 讓數字有名詞意義
    enum CardType : int
    {
        Spare = 4,
        Heart = 3,
        Diamond = 2,
        Club = 1
    }
    private List<int> cards = new List<int>();
    private List<int> playerCards = new List<int>();
    public Text totalOutput;
    private int numberCount = 5;//字串長度

    void Start()
    {
        this.shuffle();
    }
    private void shuffle()
    {
        this.cards.Clear();
        ///把撲克牌52張牌都存進陣列裡
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 13; j++)
            {
                cards.Add(i * 100 + j);
            }
        }
    }
    private bool isCardsEnough()
    {
        Debug.Log(cards.Count);
        if (this.cards.Count < this.numberCount)
        {
            return false;
        }
        return true;
    }

    public void randomNum()
    {
        if (this.isCardsEnough() == false)
        {
            this.shuffle();
            this.totalOutput.text = "重新洗牌";
            return;
        }

        this.totalOutput.text = null;//玩家在顯示框顯示初始值
        playerCards.Clear();
        ///產生隨機數塞到字串裡
        for (int i = 0; i < numberCount; i++)
        {
            int rnd = Random.Range(0, cards.Count);
            int cardIndex = cards[rnd];
            this.playerCards.Add(cardIndex);
            cards.RemoveAt(rnd);
        }

        ///
        displayList();//呼叫displayList方法
    }

    ///升冪排序用法
    public void bubbleSortUp(List<int> list)
    {
        int len = list.Count;//list陣列的長度
        for (int i = 1; i <= len - 1; i++)
        {
            for (int j = 1; j <= len - i; j++)
            {
                bool change = false;
                int pointA = list[j] % 100;
                int pointB = list[j - 1] % 100;
                if (pointA < pointB)
                {
                    change = true;
                }
                else if (pointA == pointB)
                {
                    int colorA = list[j] / 100;
                    int colorB = list[j - 1] / 100;
                    if (colorA < colorB)
                    {
                        change = true;
                    }
                }
                if (change)
                {
                    int temp = list[j];//(J=1時)list[1]的值存到temp
                    list[j] = list[j - 1];//list[0]存到list[1]
                    list[j - 1] = temp;//（J=1時）把暫存值放到list[0]
                }
            }
        }
    }
    ///
    ///降冪排序用法
    public void bubbleSortDown(List<int> list)
    {
        int len = list.Count;//list陣列的長度
        for (int i = 1; i <= len - 1; i++)
        {
            for (int j = 1; j <= len - i; j++)
            {
                bool change = false;
                int pointA = list[j] % 100;
                int pointB = list[j - 1] % 100;
                if (pointA > pointB)
                {
                    change = true;
                }
                else if (pointA == pointB)
                {
                    int colorA = list[j] / 100;
                    int colorB = list[j - 1] / 100;
                    if (colorA > colorB)
                    {
                        change = true;
                    }
                }
                if (change)
                {
                    int temp = list[j];//(J=1時)list[1]的值存到temp
                    list[j] = list[j - 1];//list[0]存到list[1]
                    list[j - 1] = temp;//（J=1時）把暫存值放到list[0]
                }
            }
        }
    }
    ///
    ///點了降冪排序按鈕會發生的事
    public void powerDownBtnClick()
    {
        bubbleSortDown(playerCards);
        displayList();
    }
    ///
    ///點了降冪排序按鈕會發生的事
    public void powerUpBtnClick()
    {
        bubbleSortUp(playerCards);
        displayList();
    }
    ///

    private void displayList()
    {
        ///顯示字串
        string str = "";
        foreach (int cardPoint in this.playerCards)//所有在cards字串裡的數
        {
            str += this.getCardPoint(cardPoint) + "\n";
        }
        ///
        this.totalOutput.text = str;
    }

    private string getCardPoint(int num)
    {
        int color = num / 100;
        int point = num % 100;
        string str = "";
        switch ((CardType)color)
        {
            case CardType.Club:
                str += "梅花" + point;
                break;
            case CardType.Diamond:
                str += "鑽石" + point;
                break;
            case CardType.Heart:
                str += "紅心" + point;
                break;
            case CardType.Spare:
                str += "黑桃" + point;
                break;
            default: break;
        }
        return str;//回傳
    }
    ///
}

