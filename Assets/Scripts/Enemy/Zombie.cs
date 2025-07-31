using UnityEngine;

public class Zombie : Enemy
{
    protected override void Attack(IDamageable target)
    {
        Debug.Log("Zombie attacks!");
        target.TakeDamage(damage);
    }
}
