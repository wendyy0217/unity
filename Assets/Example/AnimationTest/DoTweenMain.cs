using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DoTweenMain : MonoBehaviour
{
    public Transform sprite = null;

    void Start()
    {
        //Tween myTween = this.sprite.transform.DOMoveX(3, 0);
        Tween myTween2 = this.sprite.transform.DOLocalRotate(new Vector3(0, 200, 0), 1);
    }

    void Update()
    {

    }
}
