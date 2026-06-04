using UnityEngine;

public class Hidrante : MonoBehaviour
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