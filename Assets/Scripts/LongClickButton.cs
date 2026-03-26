using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool pointerDown;
    private float pointerDownTimer;
    public float requiredHoldTime;
    public AudioSource audioSource;
    public AudioClip fillSound;
    public UnityEvent onLongClick;
    [SerializeField]
    private Image fillImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*if(audioSource != null && fillSound != null)
        {
            audioSource.clip = fillSound;
        }*/
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pointerDown = true;
        Debug.Log("OnPointerDown");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Reset();
        Debug.Log("OnPointerUp");
    }
    // Update is called once per frame
    void Update()
    {
        if (pointerDown)
        {
            pointerDownTimer += Time.deltaTime;
            if (pointerDownTimer > requiredHoldTime)
            {
                if (onLongClick != null)
                    onLongClick.Invoke();

                Reset();
                return;
            }
            fillImage.fillAmount = pointerDownTimer / requiredHoldTime;
            if(fillSound != null && audioSource != null && !audioSource.isPlaying)
            {
                //audioSource.Play();
                audioSource.PlayOneShot(fillSound);
            }
        }
    }
    private void Reset()
    {
        pointerDown = false;
        pointerDownTimer = 0;
        if(fillSound != null && audioSource != null)
        {
            audioSource.Stop();
        }
        fillImage.fillAmount = pointerDownTimer / requiredHoldTime;
    }
}
