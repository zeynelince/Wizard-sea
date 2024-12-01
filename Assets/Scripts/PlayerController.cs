using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Animator bileşenini al
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Örnek olarak, input'a bağlı olarak animasyonları kontrol etme
        // Bunları kendi oyun mantığınıza göre değiştirebilirsiniz
        
        // Yürüyüş animasyonu için kontrol
        if (Input.GetKey(KeyCode.W)) // W tuşuna basılı olduğunda yürüme
        {
            animator.SetBool("walking", true);
        }
        else
        {
            animator.SetBool("walking", false);
        }

        // Ölüme geçiş için örnek kontrol
        if (Input.GetKeyDown(KeyCode.E)) // D tuşuna basıldığında ölme
        {
            animator.SetTrigger("Death 0");
        }

        // Darbe alma animasyonu için kontrol
        if (Input.GetKeyDown(KeyCode.H)) // H tuşuna basıldığında darbe alma
        {
            animator.SetTrigger("Take-Hit");
        }

        // Uçma animasyonu için kontrol
        if (Input.GetKey(KeyCode.F)) // F tuşuna basılı olduğunda uçma
        {
            animator.SetBool("Fly", true);
        }
        else
        {
            animator.SetBool("Fly", false);
        }
        if (Input.GetKeyDown(KeyCode.Space)) // Space tuşuna basıldığında saldırı yap
        {
            animator.SetTrigger("Attack");
        }
        transform.localScale = new Vector3(2f, 2f, 1f);
    }
}
