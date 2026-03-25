using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    public void Play(string animationName)
    {
        if (animator != null)
        {
            animator.Play(animationName);
        }
        else
        {
            Debug.LogWarning("Animator component not found.");
        }
    }
}
