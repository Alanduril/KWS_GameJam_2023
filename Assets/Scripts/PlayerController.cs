using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField]
    public float moveSpeed = 5f;
    //[SerializeField]
    //public float jumpForce = 10f;
    private bool isGrounded;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player is "Grounded"
        isGrounded = Physics2D.OverlapCircle(transform.position, 0.1f, LayerMask.GetMask("Ground"));
        
        //Handle player input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
        rb.velocity = movement;
        /* Handle Jumping
         * if (isGrounded && Input.GetButtonDown("Jump") {
         * rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
         * }
         */
    }
}
