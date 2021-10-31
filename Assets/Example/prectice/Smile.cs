using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smile : Monster
{
    //private int hp;
    public Smile()
    {
        hp = 500;
        base.hp = 10;
    }
    public override void introduceSelf() 
    {
        this.outPut.text = /*base.introduceSelf() +*/ "我是史萊姆～"+"血量是"+getHp();
    }
    
}
