using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenTest01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.DOMoveX(5, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
