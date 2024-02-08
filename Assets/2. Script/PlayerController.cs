using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField]
    Rigidbody2D rigid;

    [Header("Specs")]
    [SerializeField]
    float jumpSpeed;

    private void Jump()
    {
        rigid.velocity = Vector2.up * jumpSpeed;
    }
    private void OnJump(InputValue value)
    {
        if(value.isPressed)
        {
            Jump();
        }
    }
    IEnumerator JumpTimer()
    {
        yield return new WaitForSeconds(2.0f);
    }

}
