using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private Unit _target;

    private void Update()
    {
        LookAtTarget();
        MoveStep();
    }

    public void Init(Unit target)
    {
        _target = target;

        LookAtTarget();
    }

    protected virtual float GetMovementSpeed()
    {
        return _movementSpeed;
    }

    private void LookAtTarget()
    {
        transform.LookAt(_target.transform.position);
    }

    private void MoveStep()
    {
        Vector3 step = Vector3.forward * (GetMovementSpeed() * Time.deltaTime);
        transform.Translate(step);
    }
}