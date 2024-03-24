using UnityEngine;

public class CardView : MonoBehaviour
{
  private CardInstance _cardInstance;
  [SerializeField] private GameObject _sprite;

  public CardInstance CardInstance => _cardInstance;

  public void Init(CardInstance cardInstance)
  {
    _cardInstance = cardInstance;
  }

  public void Rotate(bool up)
  {
    _sprite.SetActive(up);
  }
}