using UnityEngine;

public class TransitionManager : MonoBehaviour
{
    [SerializeField]
    private Transition transition;

    public void TriggerTransition()
    {
        transition.SwapSprites();
    }
}

[System.Serializable]
public class Transition
{
    [SerializeField]
    private GameObject from;
    [SerializeField]
    private GameObject to;
    [SerializeField]
    private GameObject upwardArrow; // UI
    [SerializeField]
    private GameObject downwardArrow; // UI

    public void SwapSprites()
    {
        from.SetActive(false);  // Hide initial view
        to.SetActive(true);  // Show new view

        if (upwardArrow != null)
        {
            upwardArrow.SetActive(true);  // Show upward button
        }

        if (downwardArrow != null)
        {
            downwardArrow.SetActive(true);  // Show downward button
        }
    }
}
