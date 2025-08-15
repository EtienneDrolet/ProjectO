using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    [SerializeField]private int speed;
    private Rigidbody2D rb;
    PlayerInput playerInput;
    float MaxHP = 100;
    [SerializeField]float HP = 100;


    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        InputSystem.actions.Disable();
        playerInput.currentActionMap?.Enable();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        

        if (collision.collider.GetComponent<DamagingArea>())
        {
            ChangeHP(collision.collider.GetComponent<DamagingArea>().GetDMG());
        }
    }

    private void ChangeHP(int hpChange)
    {
        print("bang");
        HP += hpChange;

        Dictionary<string, object> parameters = new Dictionary<string, object>
        {
            { "newHP", HP }
        };

        EventManager.Instance().TriggerEvent(EEvents.PLYR_HP_CHANGE, parameters);
    }

    public void OnMove(InputValue value)
    {
        var v = value.Get<Vector2>();

        rb.linearVelocity = new Vector2(v.x * speed, v.y * speed);
    }
}
