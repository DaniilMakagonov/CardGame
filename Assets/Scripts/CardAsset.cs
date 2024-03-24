using UnityEngine;

[CreateAssetMenu(fileName = "Card Asset", menuName = "SO/new Card Asset")]
public class CardAsset : ScriptableObject
{
  [SerializeField] private string _cardName;

  [SerializeField] private Color _color;

  [SerializeField] private Sprite _sprite;

  public string CardName
  {
    get => _cardName;
    set => _cardName = value;
  }

  public Color Color
  {
    get => _color;
    set => _color = value;
  }
}