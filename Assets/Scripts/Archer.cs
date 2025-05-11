using TMPro;
using UnityEngine;

public class Archer : Enemy
{
    [SerializeField] private int _arrowCount;
    [SerializeField] private TextMeshPro _arrowCountText;

    private void Awake()
    {
        float heightModifier = 3f;
        _arrowCountText.transform.localPosition = Vector3.up * heightModifier;

        _arrowCountText.alignment = TextAlignmentOptions.Center;
        _arrowCountText.text = $"Arrows: {_arrowCount}";
    }
}