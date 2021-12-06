using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    public float playerSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = -Input.GetAxisRaw("Vertical"); //reversing the input

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        PlayerMovement();
    }

    public void PlayerMovement()
    {
        rb.MovePosition(rb.position - movement * playerSpeed * Time.fixedDeltaTime);    //reversing the movement
    }
}
