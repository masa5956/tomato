using UnityEngine;
using DG.Tweening;
public class DoTweenLoop : MonoBehaviour
{
    void Start()
    {
        DOTween.Sequence()
        .Append(this.transform.DOMoveX(3, 1f).SetRelative())
        .Append(this.transform.DOMoveX(-3, 2f).SetRelative())
        .SetLoops(5)
        .Play();
    }
}