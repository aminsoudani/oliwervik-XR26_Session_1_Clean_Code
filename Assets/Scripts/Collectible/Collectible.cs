using UnityEngine;

public abstract class Collectible : MonoBehaviour
{
    public abstract int Value { get; }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var scorable = other.GetComponent<IScorable>();
            if (scorable != null)
            {
                scorable.AddScore(Value);
            }
            Destroy(gameObject);
        }
    }
}
