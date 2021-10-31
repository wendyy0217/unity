using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creature : MonoBehaviour
{
   private int hp = 100;
   public int GetHP()
   {
       return hp;
   }
   public void Injured(int injuredPoint)
   {
       hp-=injuredPoint;
   }
}
