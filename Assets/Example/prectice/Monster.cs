using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster :  MonoBehaviour
{
    public Text outPut;
    protected int hp = 100;
    // private string name;
    // public void SetName(string name)
    // {
    //     this.name = name;
    // }
    public int getHp()
    {
        return hp;

    }
    public virtual void introduceSelf()
    {
        this.outPut.text = "我是一個怪物";
    }
}
