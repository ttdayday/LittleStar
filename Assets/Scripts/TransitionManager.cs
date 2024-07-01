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

    public void Go()
    {
        // Do stuff here
    }
}