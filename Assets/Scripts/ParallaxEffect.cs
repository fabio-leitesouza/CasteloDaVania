using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallaxEffectMultiplier;

    void Start()
    {
        // Pega a posi��o inicial do background e o comprimento da sprite
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // Calcula a dist�ncia que a c�mera percorreu
        float temp = (cam.transform.position.x * (1 - parallaxEffectMultiplier));
        float distance = (cam.transform.position.x * parallaxEffectMultiplier);

        // Move o fundo
        transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);

        // Faz o looping para garantir que o fundo se repete
        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }
}
