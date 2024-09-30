using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float jumpForce = 5;

    private Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
 
    void Start()
    {
        GameManager.Instance.inputManager.OnJump += HandleJump;
    }
    private void Update()
    {
        float moveDirection = GameManager.Instance.inputManager.Movement;
        transform.Translate(moveDirection *Time.deltaTime * moveSpeed, 0, 0);
    }
    private void HandleJump()
    {
        rigidbody.velocity += Vector2.up * jumpForce;
    }
}
