using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private InputManager inputManager;
    void Start()
    {
        inputManager = new InputManager();        
    }
    private void Update()
    {
        float moveDirection - inputManager.Momevent;
        transform.Translate(moveDirection, 0, 0);
    }

}
