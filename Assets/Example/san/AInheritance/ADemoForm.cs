using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ADemoForm : MonoBehaviour
{
    public Text outPut;

    public void button()
    {
        AVillager v = new AVillager();
        AMonster m = new AMonster();
        this.outPut.text = m.GetHP() + " ";
    }
}
