using UnityEngine;

public class Alien : Enemy
{
    protected override void Attack(IDamageable target, float damage)
    {
        Debug.Log("Alien attacks!");
        target.TakeDamage(damage);
    }
}
