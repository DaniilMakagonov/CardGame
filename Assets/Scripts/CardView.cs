using UnityEngine;

public class CardView : MonoBehaviour
{
  [SerializeField] private GameObject _sprite;
  [SerializeField] private Vector2 _center;

  public CardInstance CardInstance { get; private set; }

  public void Init(CardInstance cardInstance)
  {
    CardInstance = cardInstance;
  }

  public void Rotate(bool up)
  {
    _sprite.SetActive(up);
  }

  public void PlayCard()
  {
    Transform transform1;
    (transform1 = transform).SetParent(null);
    transform1.position = _center;
  }
}