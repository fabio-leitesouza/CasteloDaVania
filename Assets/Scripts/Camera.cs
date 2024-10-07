
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform playerTransform;  // Refer�ncia ao transform do jogador
    public Vector3 offset;              // Offset da c�mera em rela��o ao jogador
    public float smoothSpeed = 0.125f;  // Velocidade de suaviza��o do movimento da c�mera

    // Update � chamado uma vez por frame
    void LateUpdate()
    {
        // Calcula a posi��o desejada da c�mera, mantendo o eixo Z fixo
        Vector3 desiredPosition = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z) + offset;

        // Suaviza a transi��o da posi��o atual para a posi��o desejada
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Atualiza a posi��o da c�mera
        transform.position = smoothPosition;
    }
}