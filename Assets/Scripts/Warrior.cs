using UnityEngine;

public class Warrior : Enemy
{
    [SerializeField] private float _extraMovementSpeed;

    protected override float GetMovementSpeed()
    {
        return base.GetMovementSpeed() + _extraMovementSpeed;
    }
}
