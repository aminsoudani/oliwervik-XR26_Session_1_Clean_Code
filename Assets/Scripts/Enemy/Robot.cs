using UnityEngine;

public class Robot : Enemy
{
    protected override void Attack(IDamageable target, float damage)
    {
        Debug.Log("Robot attacks!");
        target.TakeDamage(damage);
    }
}
