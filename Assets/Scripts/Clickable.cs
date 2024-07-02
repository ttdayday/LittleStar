using UnityEngine;

public class Clickable : MonoBehaviour
{
    [SerializeField]
    private TransitionManager transitionManager;

    void OnMouseDown()
    {
        if (transitionManager != null)
        {
            transitionManager.TriggerTransition();
        }
    }
}
