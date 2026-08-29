using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        Vector2 move = Vector2.zero;

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            move.x = -1f;

        if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            move.x = 1f;

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
            move.y = 1f;

        if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
            move.y = -1f;

        transform.position += (Vector3)move.normalized * speed * Time.deltaTime;

        // Giới hạn màn hình
        float x = Mathf.Clamp(transform.position.x, -8f, 8f);
        float y = Mathf.Clamp(transform.position.y, -4f, 4f);

        transform.position = new Vector3(x, y, transform.position.z);
    }
}