using UnityEngine;

public class AcionaPorta : MonoBehaviour
{
    public PortaDupla porta;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entrou no trigger: " + other.name);

        porta.AbrirPorta();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Saiu do trigger: " + other.name);

        porta.FecharPorta();
    }
}