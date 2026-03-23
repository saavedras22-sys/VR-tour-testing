using UnityEngine;
using UnityEngine.UI;

public class ActivateScroll : MonoBehaviour
{
    public GameObject toChangeComp;
    private Scrollbar rekt;
    
    public void ActivateS()
    {
        Invoke("act", 0.1f);
        //LayoutRebuilder.MarkLayoutForRebuild(GameObject.Find("Content").GetComponent<RectTransform>());
        //LayoutRebuilder.ForceRebuildLayoutImmediate(GameObject.Find("Content").GetComponent<RectTransform>());
        //Invoke("act", 0.1f);
    }
    public void DeactivateS()
    {
        Invoke("de", 0.1f);
        //LayoutRebuilder.MarkLayoutForRebuild(GameObject.Find("Content").GetComponent<RectTransform>());
        //LayoutRebuilder.ForceRebuildLayoutImmediate(GameObject.Find("Content").GetComponent<RectTransform>());
        //Invoke("de", 0.1f);
    }
    private void act()
    {
        rekt = toChangeComp.GetComponent<Scrollbar>();
        rekt.value = 1;
    }
    private void de()
    {
        //rekt = toChangeComp.GetComponent<ScrollRect>();
        //rekt.vertical = false;
    }
}
