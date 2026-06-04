using UnityEngine;

public class BemVindo : MonoBehaviour
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