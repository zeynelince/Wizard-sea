using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb; // 2D fizik için Rigidbody
    private Animator animator; // Animator bileşeni
    private Vector2 moveInput; // Hareket verisini saklayan değişken
    public float moveSpeed = 5f; // Karakterin hareket hızı

    private bool isFacingRight = true; // Karakterin şu an hangi yöne baktığını takip eder

    void Start()
    {
        // Rigidbody ve Animator bileşenlerini al
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Input System'den hareket verilerini al
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();

        // Animator'da walking parametresini ayarla
        animator.SetBool("walking", moveInput.magnitude > 0.1f);

        // Karakterin yönünü kontrol et
        if (moveInput.x > 0 && !isFacingRight)
        {
            Flip(); // Sağa bak
        }
        else if (moveInput.x < 0 && isFacingRight)
        {
            Flip(); // Sola bak
        }
    }

    void FixedUpdate()
    {
        // Fiziksel hareket
        rb.linearVelocity = moveInput * moveSpeed;
    }

    private void Flip()
    {
        // Yüz yönünü ters çevir
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
