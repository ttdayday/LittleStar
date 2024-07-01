using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionManager : MonoBehaviour
{
    [SerializeField]
    private Transition[] transitions;
}

[Serializable]
public class Transition
{
    [SerializeField]
    private GameObject from;
    [SerializeField]
    private GameObject to;
    [SerializeField] GameObject transitionOverlay; //transitional effects
    [SerializeField] GameObject upwardArrow; //ui
    [SerializeField] GameObject downwardArrow;//ui

      public void SwapSprites()
    {
       
        from.SetActive(false);  // Hide initial view
        to.SetActive(true);  // Show zoomed-in view

        upwardArrow.SetActive(true);  // Show upward button
        downwardArrow.SetActive(true);  // Show downward button

      
    }
}