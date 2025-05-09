using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private Vector3 _fromPosition;
    [SerializeField] private Vector3 _toPosition;
    [SerializeField] private float _speed = 2f;
    [SerializeField] private float _arrivalThreshold = 0.1f;

    private Vector3 _targetPosition;

    private void Awake()
    {
        transform.position = _fromPosition;
        _targetPosition = _toPosition;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);

        float toTargetDistance = Vector3.Distance(transform.position, _targetPosition);

        if (toTargetDistance < _arrivalThreshold)
        {
            _targetPosition = _targetPosition == _toPosition ? _fromPosition : _toPosition;
        }
    }
}