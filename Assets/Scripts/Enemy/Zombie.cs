using UnityEngine;

public class Zombie : Enemy
{
    protected override void Attack(IDamageable target, float damage)
    {
        Debug.Log("Zombie attacks!");
        target.TakeDamage(damage);
    }
}
