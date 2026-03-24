using UnityEngine;

public class MenuAnimation : MonoBehaviour
{
    public float scaleX;
    public float scaleY;
    public float scaleZ;
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
        Vector3 originalScale = new Vector3(scaleX, scaleY, scaleZ);
        transform.localScale = Vector3.zero;
        transform.LeanScale(originalScale, 0.2f).setEaseInOutBack();
    }
}
