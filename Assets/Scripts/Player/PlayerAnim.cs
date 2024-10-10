using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator animator;
    private IsGroundedChecker groundedChecker;
    private Health playerHealth;
   
    private void Awake()
    {
        animator = GetComponent<Animator> ();
        groundedChecker = GetComponent<IsGroundedChecker>();
        playerHealth = GetComponent<Health>();

        playerHealth.OnHurt += PlayHurtAnim;

        GameManager.Instance.InputManager.OnAttack += PlayAttackAnim;

    }
    private void Update()
    {
        bool isWalking = GameManager.Instance.InputManager.Movement != 0;
        animator.SetBool("isWalking", isWalking);
        animator.SetBool("isJumping", !groundedChecker.IsGrounded());
    }
    private void PlayHurtAnim()
    {
        animator.SetTrigger("hurt");
    }
    private void PlayAttackAnim()
    {
        animator.SetTrigger("attack");
    }
}
