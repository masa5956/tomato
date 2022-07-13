using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenTest05 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOMoveX(5, 1f).SetRelative();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
