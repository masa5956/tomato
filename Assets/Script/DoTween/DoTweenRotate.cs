using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DORotate(new Vector3(0, 240, 0), 2f).SetEase(Ease.OutBounce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
