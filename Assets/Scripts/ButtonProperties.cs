
using UnityEngine;

public class ButtonProperties : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    string currentState = "Idle";
    private void OnEnable()
    {
        currentState = "popUpAnim";
        animator = GetComponent<Animator>();
        PlayAnimation(currentState);
    }
    private void OnDisable()
    {
        currentState = "Idle";
        PlayAnimation(currentState);
    }
    private void PlayAnimation(string anim)
    {
        animator.Play(anim);
    }
}
