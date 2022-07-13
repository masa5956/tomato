using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class DoTweenCountUp : MonoBehaviour
{
    [SerializeField] Text text;
    // Start is called before the first frame update
    void Start()
    {
        DOVirtual.Float(0f,100f,3f, value =>
        {
            text.text = "Count : " + (int)value;
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
