using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using Unity.VisualScripting;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField]
    Rigidbody2D rigid;
    [SerializeField]
    Animator animator;

    [Header("Specs")]
    [SerializeField]
    float moveSpeed;

    [Header("Events")]
    public UnityEvent OnDied;

    private void Update()
    {
        rigid.transform.right = Vector3.up * rigid.velocity * moveSpeed * Time.deltaTime;
    }

    private void Jump()
    {
        rigid.velocity = Vector2.up * GameManger.Ballance.JumpSpeed;
    }
    private void OnJump(InputValue value)
    {
        Debug.Log("tap");

        if(value.isPressed)
        {
            Jump();
        }
    }
    IEnumerator JumpTimer()
    {
        yield return new WaitForSeconds(2.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManger.Ballance.GetScore();
    }

    private void Die()
    {
        animator.SetBool("IsDie", true);
        OnDied?.Invoke();
        GameManger.GameFlow.ChangeState(GameState.GameOver);
    }
}
