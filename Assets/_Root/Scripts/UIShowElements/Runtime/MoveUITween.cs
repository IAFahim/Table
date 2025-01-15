using System;
using UnityEngine;

namespace _Root.Scripts.UIShowElements.Runtime
{
    public class MoveUITween : MonoBehaviour
    {
        public Vector3 startPosition;
        public Vector3 endPosition;
        public float duration;
        public RectTransform rectTransform;


        // private void OnEnable()
        // {
        //     motionHandle = LMotion.Create(startPosition, endPosition, duration).WithEase(ease)
        //         .BindToAnchoredPosition3D(rectTransform);
        // }
        //
        // private void OnDestroy()
        // {
        //     if(motionHandle.IsActive()) motionHandle.Cancel();
        // }
    }
}