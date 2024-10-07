using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator animator;
    private IsGroundChecker groundedChecker;
   
    private void Awake()
    {
        animator = GetComponent<Animator> ();
        groundedChecker = GetComponent<IsGroundChecker>();
    }
    private void Update()
    {
        bool isWalking = GameManager.Instance.inputManager.Movement != 0;
        animator.SetBool("isWalking", isWalking);
        animator.SetBool("isJumping", !groundedChecker.IsGrounded());
    }
}
