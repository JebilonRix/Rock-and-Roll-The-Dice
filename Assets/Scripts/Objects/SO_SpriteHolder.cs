using UnityEngine;

[CreateAssetMenu(fileName = "SpriteHolder", menuName = "SpriteHolder")]
public class SO_SpriteHolder : ScriptableObject
{
    [SerializeField] private Sprite[] _sprites;
    public Sprite[] Sprites { get => _sprites; }
}