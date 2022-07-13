using UnityEngine;
using DG.Tweening;
public class DoTweenJoin : MonoBehaviour
{
    void Start()
    {
        DOTween.Sequence()
        .Append(this.transform.DOMoveX(3, 1f).SetRelative())
        .Append(this.transform.DOMoveY(-3, 1f).SetRelative())
        .Join(this.transform.DORotate(new Vector3(0, 300, 0), 1f).SetRelative())
        .Play();
    }
}