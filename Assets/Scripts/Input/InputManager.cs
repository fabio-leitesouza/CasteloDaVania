public class InputManager
{
    private PlayerControls playerControls;

    public float Momevent => playerControls.Gameplay.Movement.ReadValue<float>();

    public InputManager()
    {
        playerControls = new PlayerControls();
        playerControls.Gameplay.Enable();
    }
}
