using UnityEngine;
using UnityEngine.Events;

public class HoverButon : MonoBehaviour
{
    public UnityEvent onHoverEnter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (onHoverEnter == null)
            onHoverEnter = new UnityEvent();
    }

    public void onHoverEnterEvent(GameObject obj)
    {
        if(obj.tag == "PlayerFinger")
            onHoverEnter.Invoke();
    }
}
