using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerGameplay : MonoBehaviour
{
    public void GrabHead(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            CastRay();
        }
    }

    void CastRay()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        RaycastHit2D raycastHit2D = Physics2D.Raycast(mousePosition, Vector2.zero);

        if (raycastHit2D.collider != null)
        {
            Debug.Log($"Hit: {raycastHit2D.collider.name}");
        }
    }
}
