using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///enum=枚舉 讓數字有名詞意義
enum CardType : int
{
    Spare = 4,
    Heart = 3,
    Diamond = 2,
    Club = 1
}

public class ListExample : MonoBehaviour
{
    public int cardsCount = 7;//發牌張數
    public Text player1Output = null;//Text是物件不是字串或字，所以用null。
    public Text player2Output = null;//Text是物件不是字串或字，所以用null。
    public Text totalOutput = null;//Text是物件不是字串或字，所以用null。
    private List<int> player2Cards = new List<int>();//玩家卡牌陣列
    private List<int> player1Cards = new List<int>();//玩家1卡牌陣列
    private List<int> cards = new List<int>();//（動態陣列寫法）全部卡牌的陣列

    void Start()
    {
        this.init();
    }

    private void init()
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
        this.totalOutput.text = cards.Count + " ";//顯示目前的牌數
        this.player1Output.text = "";
        this.player2Output.text = "";//把玩家的牌清空
    }
    ///取得卡牌花色及點數
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

    public void player1CardType()
    {
        if (this.isCardsEnough() == false)
        {
            return;
        }

        this.player1Output.text = null;//玩家在顯示框顯示初始值
        this.player1Cards.Clear();//清空player1Cards

        ///隨機取一數，取cardsCount次，並把該數移除
        for (int i = 0; i < cardsCount; i++)
        {
            int rnd = Random.Range(0, cards.Count);//隨機取0到cards.Count之數
            int cardIndex = cards[rnd];//把陣列裡cards的編號rnd代表的數存進cardIndex
            this.player1Cards.Add(cardIndex);//把cardIndex數存入玩家卡牌陣列中
            cards.RemoveAt(rnd);//cards//陣列.RemoveAt//移除第幾格(rnd)//編號rnd
        }
        ///

        ///foreach用法
        foreach (int cardPoint in this.player1Cards)//所有玩家牌(playerCards)裡的牌(cardPoint)
        {
            this.player1Output.text += cardPoint + " " + this.getCardPoint(cardPoint) + "\n";
        }
        this.totalOutput.text = cards.Count + " ";//顯示每按一次的總牌數
        ///
    }

    public void player2CardType()
    {
        if (this.isCardsEnough() == false)
        {
            return;
        }

        this.player2Output.text = null;//玩家在顯示框顯示初始值
        this.player2Cards.Clear();//清空player2Cards

        ///隨機取一數，取cardsCount次，並把該數移除
        for (int i = 0; i < cardsCount; i++)
        {
            int rnd = Random.Range(0, cards.Count);//隨機取0到cards.Count之數
            int cardIndex = cards[rnd];//把陣列裡cards的編號rnd代表的數存進cardIndex
            this.player2Cards.Add(cardIndex);//把cardIndex數存入玩家卡牌陣列中
            cards.RemoveAt(rnd);//cards//陣列.RemoveAt//移除第幾格(rnd)//編號rnd
        }
        ///

        ///foreach用法
        foreach (int cardPoint in this.player2Cards)//所有玩家牌(playerCards)裡的牌(cardPoint)
        {
            this.player2Output.text += cardPoint + " " + this.getCardPoint(cardPoint) + "\n";
        }
        this.totalOutput.text = cards.Count + " ";//顯示每按一次的總牌數
        ///
    }

    private bool isCardsEnough()
    {
        if (this.cards.Count < this.cardsCount)
        {
            Debug.Log("牌數不夠");
            return false;
        }
        return true;
    }

    //重新開始
    public void restart()
    {
        this.init();
    }
}

