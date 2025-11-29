using UnityEngine;
using UnityEngine.InputSystem;

public class playerWalk : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float Horizontal;
    public float speed = 1f;
    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Keyboard.current.aKey.isPressed)
        {
            Horizontal = -0.2f;
            Debug.Log("kiri");
        }else if (Keyboard.current.dKey.isPressed)
        {
            Horizontal = 0.2f;
            Debug.Log("Kanan");
        }
        else
        {
            Horizontal = 0;
        }
        transform.position = new Vector3(transform.position.x + Horizontal, transform.position.y, transform.position.z)*speed;
    }
}
