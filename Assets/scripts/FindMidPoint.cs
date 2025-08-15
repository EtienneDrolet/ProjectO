using UnityEngine;
using UnityEngine.InputSystem;

public class FindMidPoint : MonoBehaviour
{
    [SerializeField] Transform PlayerPos;
    Vector2 MousePos;


    private void Update()
    {
        MousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = Vector2.Lerp(PlayerPos.position, MousePos, 0.15f);
    }
}
