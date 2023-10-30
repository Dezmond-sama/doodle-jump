using UnityEngine;

public class PlatfromDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Platform>() != null)
        {
            Pool.Push(other.gameObject);
        }
    }
}
