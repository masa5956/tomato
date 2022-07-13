using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenAppend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DOTween.Sequence()
          .Append(this.transform.DOMoveX(20, 1f).SetRelative())
          .Append(this.transform.DOMoveY(-20, 1f).SetRelative())
          .Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
