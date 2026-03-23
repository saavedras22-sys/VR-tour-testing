using UnityEngine;
using UnityEngine.UI;

public class ActivateScroll : MonoBehaviour
{
    public GameObject toChangeComp;
    private ScrollRect rekt;
    
    public void ActivateS()
    {
        rekt = toChangeComp.GetComponent<ScrollRect>();
        rekt.vertical = true;
    }
    public void DeactivateS()
    {
        rekt = toChangeComp.GetComponent<ScrollRect>();
        rekt.vertical = false;
    }
}
