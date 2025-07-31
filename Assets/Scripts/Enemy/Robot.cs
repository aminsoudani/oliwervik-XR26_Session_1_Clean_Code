using UnityEngine;

public class Robot : Enemy
{
    protected override void Attack(IDamageable target)
    {
        Debug.Log("Robot shoots laser!");
        target.TakeDamage(damage * 1f);
    }
}
