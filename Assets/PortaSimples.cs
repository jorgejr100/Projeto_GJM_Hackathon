using UnityEngine;

public class PortaSimples : MonoBehaviour
{
    public float anguloAberto = 90f;
    public float velocidade = 2f;

    private bool aberta = false;
    private Quaternion rotacaoFechada;
    private Quaternion rotacaoAberta;

    void Start()
    {
        rotacaoFechada = transform.rotation;
        rotacaoAberta = Quaternion.Euler(
            transform.eulerAngles + new Vector3(0, anguloAberto, 0)
        );
    }

    void Update()
    {
        if (aberta)
        {
            transform.rotation = Quaternion.Lerp(
                transform.rotation,
                rotacaoAberta,
                Time.deltaTime * velocidade
            );
        }
        else
        {
            transform.rotation = Quaternion.Lerp(
                transform.rotation,
                rotacaoFechada,
                Time.deltaTime * velocidade
            );
        }
    }

    void OnMouseDown()
    {
        aberta = !aberta;
    }
}