using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target; // Takip edilecek karakter
    public float smoothSpeed = 5f; // Kameranın takip hızı
    public Vector3 offset = new Vector3(0, 0, -10); // Kamera uzaklığı

    void LateUpdate()
    {
        if (target == null) return;

        // Kameranın gitmesi gereken pozisyon
        Vector3 desiredPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
    }
}
