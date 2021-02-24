using UnityEngine;

public class PlayerContainer : MonoBehaviour
{
    public static PlayerContainer Instance;
    
    public Joystick Joystick;
    public Touch Touch;

    private void Awake()
    {
        Instance = this;
    }
}