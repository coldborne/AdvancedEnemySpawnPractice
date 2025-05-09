using TMPro;
using UnityEngine;

public class Archer : Enemy
{
    [SerializeField] private int _arrowCount;

    private TextMeshPro _arrowCountText;

    private void Awake()
    {
        string textViewName = "ArrowText";
        GameObject textView = new GameObject(textViewName);
        textView.transform.SetParent(transform);
        
        float heightModifier = 3f;
        textView.transform.localPosition = Vector3.up * heightModifier;
        
        _arrowCountText = textView.AddComponent<TextMeshPro>();
        
        _arrowCountText.alignment = TextAlignmentOptions.Center;
        _arrowCountText.text = $"Arrows: {_arrowCount}";
    }
}