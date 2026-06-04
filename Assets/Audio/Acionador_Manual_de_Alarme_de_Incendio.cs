using UnityEngine;

public class Acionador_Manual_de_Alarme_de_Incendio: MonoBehaviour
{
    public AudioSource audioSource;

    private bool tocou = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!tocou)
        {
            tocou = true;

            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}