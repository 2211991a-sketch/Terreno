using UnityEngine;

public class Nave : MonoBehaviour
{
    // Velocidades
    public float moveSpeed = 10f;
    public float verticalSpeed = 5f;
    public float rotationSpeed = 100f;

    void Update()
    {
        // Movimiento adelante/atrás
        float move = Input.GetAxis("Vertical");

        // Giro izquierda/derecha
        float rotate = Input.GetAxis("Horizontal");

        // Subir y bajar
        float vertical = 0f;

        if (Input.GetKey(KeyCode.Space))
        {
            vertical = 1f;
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            vertical = -1f;
        }

        // Movimiento
        transform.Translate(Vector3.forward * move * moveSpeed * Time.deltaTime);

        // Subir/Bajar
        transform.Translate(Vector3.up * vertical * verticalSpeed * Time.deltaTime);

        // Rotación
        transform.Rotate(Vector3.up * rotate * rotationSpeed * Time.deltaTime);
    }
}