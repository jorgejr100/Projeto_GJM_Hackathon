using UnityEngine;

public class PortaDupla : MonoBehaviour
{
    public Transform portaEsquerda;
    public Transform portaDireita;

    public float distancia = 1f;
    public float velocidade = 2f;

    private Vector3 esquerdaFechada;
    private Vector3 direitaFechada;

    private Vector3 esquerdaAberta;
    private Vector3 direitaAberta;

    private bool aberta = false;

    private void Start()
    {
        esquerdaFechada = portaEsquerda.localPosition;
        direitaFechada = portaDireita.localPosition;

        esquerdaAberta = esquerdaFechada + Vector3.left * distancia;
        direitaAberta = direitaFechada + Vector3.right * distancia;

        Debug.Log("Porta pronta");
    }

    private void Update()
    {
        if (aberta)
        {
            portaEsquerda.localPosition = Vector3.Lerp(
                portaEsquerda.localPosition,
                esquerdaAberta,
                Time.deltaTime * velocidade);

            portaDireita.localPosition = Vector3.Lerp(
                portaDireita.localPosition,
                direitaAberta,
                Time.deltaTime * velocidade);
        }
        else
        {
            portaEsquerda.localPosition = Vector3.Lerp(
                portaEsquerda.localPosition,
                esquerdaFechada,
                Time.deltaTime * velocidade);

            portaDireita.localPosition = Vector3.Lerp(
                portaDireita.localPosition,
                direitaFechada,
                Time.deltaTime * velocidade);
        }
    }

    public void AbrirPorta()
    {
        aberta = true;
        Debug.Log("Abrindo porta");
    }

    public void FecharPorta()
    {
        aberta = false;
        Debug.Log("Fechando porta");
    }
}