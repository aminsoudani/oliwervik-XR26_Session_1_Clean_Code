using UnityEngine;

public class Alien : Enemy
{
    protected override void Attack(IDamageable target)
    {
        Debug.Log("Alien attacks!");
        target.TakeDamage(damage * 1.0f);
    }
}
