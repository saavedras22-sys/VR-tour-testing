using UnityEngine;

public class MenuAnimation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {/*
        Debug.Log("playa animazione");
        Vector3 originalScale = transform.localScale;
        transform.localScale = Vector3.zero;
        transform.LeanScale(originalScale, 0.2f).setEaseInOutBack();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartAnimation()
    {
        Debug.Log("playa animazione");
        Vector3 originalScale = transform.localScale;
        transform.localScale = Vector3.zero;
        transform.LeanScale(originalScale, 0.2f).setEaseInOutBack();
    }
}
