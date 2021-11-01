using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationBG : MonoBehaviour
{
    //獲得material
    Material material;
    Vector2 movement;

    public Vector2 speed;


    void Start()
    {
        //用Renderer裡調整材質所以<Renderer>
        //獲得Renderer的Component裡的material
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        movement += speed*Time.deltaTime;
        material.mainTextureOffset = movement;
    }
}
