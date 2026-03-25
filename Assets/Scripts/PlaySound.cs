using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;
    public void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }
    public void Play(AudioClip clip)
    {
        if (audioSource != null)
        {
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.LogWarning("AudioSource component not found.");
        }
    }
}
