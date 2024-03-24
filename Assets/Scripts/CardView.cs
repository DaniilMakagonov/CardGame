using UnityEngine;

public class CardView : MonoBehaviour
{
  [SerializeField] private GameObject _sprite;
  [SerializeField] private Vector2 _center;
  private GameObject _back;

  public CardInstance CardInstance { get; private set; }

  public void Init(CardInstance cardInstance)
  {
    CardInstance = cardInstance;
    (_back = Instantiate(_sprite, transform, false)).SetActive(false);
  }

  public void Rotate(bool up)
  {
    _back.SetActive(!up);
  }

  public void PlayCard()
  {
    Transform transform1;
    (transform1 = transform).SetParent(null);
    transform1.position = _center;
  }
}