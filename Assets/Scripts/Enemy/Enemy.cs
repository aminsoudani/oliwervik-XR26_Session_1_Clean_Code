using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected float damage = 10f;

    protected virtual void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            var damageable = col.gameObject.GetComponent<IDamageable>();
            if (damageable != null)
            {
                Attack(damageable, damage);
                Destroy(gameObject);
            }
        }
    }

    protected abstract void Attack(IDamageable target, float damage);
}
