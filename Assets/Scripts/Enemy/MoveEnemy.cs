using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float velocidade = 2f; // Velocidade do movimento
    public float distanciaLimite = 3f; // Dist�ncia que o inimigo se mover�
    private Vector3 pontoInicial;
    private Vector3 pontoFinal;
    private bool indoParaDireita = false;


    void Start()
    {
        pontoInicial = transform.position;
        pontoFinal = pontoInicial + new Vector3(distanciaLimite, 0, 0); // Mova para a direita
    }

    void Update()
    {
        Mover();
    }

    void Mover()
    {
        // Mova o inimigo entre os pontos inicial e final
        if (indoParaDireita)
        {
            transform.position = Vector3.MoveTowards(transform.position, pontoFinal, velocidade * Time.deltaTime);
            if (transform.position == pontoFinal)
            {
                indoParaDireita = false; // Mude a dire��o
                transform.localScale = Vector3.one;

            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pontoInicial, velocidade * Time.deltaTime);
            if (transform.position == pontoInicial)

            {
                indoParaDireita = true; // Mude a dire��o
                transform.localScale = new Vector3(-1, 1, 1);


            }
        }
    }

}
