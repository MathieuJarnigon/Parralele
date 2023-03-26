using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManagement : MonoBehaviour
{
    public float jumpingPower;
    public CapsuleCollider2D capsule2D;
    public LayerMask layerMask;

    private bool isFacingRight = true;
    private bool isJump = true;
    private float horizontal;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.001f && isJump == true)
        {
            rb.AddForce(new Vector2(0, jumpingPower), ForceMode2D.Impulse);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        Collider2D[] colliders = Physics2D.OverlapCapsuleAll(capsule2D.bounds.center,
            capsule2D.bounds.size, CapsuleDirection2D.Vertical, capsule2D.transform.rotation.eulerAngles.z, layerMask);

        if (colliders.Length > 0)
        {
            isJump = true;
        }
        else
        {
            isJump = false;
        }
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
