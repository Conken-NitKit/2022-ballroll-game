using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class LogoAnim : MonoBehaviour
{
    [SerializeField] private RectTransform charRectTransform;
    [SerializeField] private RectTransform barRectTransform;
    [SerializeField] private GameObject logoCanvas;
    [SerializeField] private Vector3 goalPoint;
    [SerializeField] private int jumpPower;
    [SerializeField] private int numJumps; 
    [SerializeField] private int jumpDuration;
    private Sequence sequence;
    void Start()
    {
        StartCoroutine(LogoJumpAnimation());
    }

    IEnumerator LogoJumpAnimation()
    {
        CanvasGroup logoCanvasAlpha = logoCanvas.GetComponent<CanvasGroup>();
        sequence = DOTween.Sequence();
        sequence
            .AppendInterval(0.5f)
            .Append(
                charRectTransform.DOLocalJump(
                    goalPoint,
                    jumpPower,
                    numJumps,
                    jumpDuration
                ).SetEase(Ease.OutQuad)
            )
            .AppendInterval(0.3f)
            .Append(DOTween.ToAxis(
                    () => barRectTransform.offsetMax,
                    right => barRectTransform.offsetMax = new Vector2(right.x, barRectTransform.offsetMax.y),
                    -270,
                    1.3f
                ).SetEase(Ease.OutCubic)
            )
            .Join(DOTween.ToAxis(
                    () => barRectTransform.offsetMin,
                    left => barRectTransform.offsetMin = new Vector2(left.x, barRectTransform.offsetMin.y),
                    535,
                    1.3f
                ).SetEase(Ease.InCubic)
            )
            .AppendInterval(0.4f)
            .Append(DOTween.To(
                () => logoCanvasAlpha.alpha,
                (n) => logoCanvasAlpha.alpha = n,
                0f,
                0.7f)
                .SetEase(Ease.OutCubic)
            )
            .OnComplete(
                ()=>
                Destroy(logoCanvas)
                );
        yield return null;
    }
    
    private void OnDisable()
    {
        if (DOTween.instance != null)
        {
            sequence?.Kill();
        }
    }
}
