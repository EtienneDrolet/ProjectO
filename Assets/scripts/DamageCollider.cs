using UnityEngine;

public class DamageCollider : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<DamagingArea>())
        {
            transform.parent.GetComponent<Character>().ChangeHP(collision.GetComponent<DamagingArea>().GetDMG());
        }
    }
}
