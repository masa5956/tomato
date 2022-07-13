using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOScale(new Vector3(5,5, 5), 2f).SetEase(Ease.OutBounce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
