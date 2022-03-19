using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Card : MonoBehaviour
{
    public Image targetImage = null;
    public Button btn = null;
    public void init()
    {
        targetImage.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        this.btn.gameObject.SetActive(true);
    }
    public void showCard()
    {
        this.btn.gameObject.SetActive(false);
        DOTween.Sequence()
            // .Append(this.targetImage.transform.DOLocalRotate(new Vector3(0, 0, 0), 0))
            .Append(this.targetImage.transform.DOLocalRotate(new Vector3(0, 90, 0), 0.5f))
            .AppendCallback(() =>
            {
                //this.setImage(myType);
            })
            .Append(this.targetImage.transform.DOLocalRotate(new Vector3(0, 180, 0), 0.5f));
    }
}