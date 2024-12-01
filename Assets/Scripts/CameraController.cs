using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 10f; // Hareket hızı

    void Update()
    {
        // Klavye girdilerini al
        float horizontal = Input.GetAxis("Horizontal"); // A ve D veya ok tuşları
        float vertical = Input.GetAxis("Vertical"); // W ve S veya ok tuşları

        // Kameranın hareket vektörünü belirle
        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;

        // Kamerayı hareket ettir
        transform.Translate(movement, Space.Self);
    }
}
