//#region import
using System.Collections.Generic;
using System.Collections;
// using NaughtyAttributes;
using UnityEngine;
// using DG.Tweening;
using System;
//#endregion

public class AnimatorControllerBot : MonoBehaviour
{
    //#region editors fields and properties

    [SerializeField] private string animationOnClick;
    [SerializeField] private Animator animatorHand;

    //#endregion

    //#region public fields and properties
    //#endregion

    //#region private fields and properties

    private Animator animator;

    //#endregion


    //#region life-cycle callbacks

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    //#endregion

    //#region public methods

    public void OnClick()
    {
        animator.SetTrigger(animationOnClick);
        animatorHand.SetTrigger(animationOnClick);
    }

    //#endregion

    //#region private methods
    //#endregion

    //#region event handlers
    //#endregion
}