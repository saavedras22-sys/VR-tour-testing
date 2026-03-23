using UnityEngine;

public class HideObj : MonoBehaviour
{
    public bool hidden;
    public void Hide()
    {
        gameObject.SetActive(!hidden);
    }
    public void HideBasedOnPrevious()
    {
        if(PreviousScene.OldScene != "Title")
        {
            gameObject.SetActive(false);
        }
    }
}
