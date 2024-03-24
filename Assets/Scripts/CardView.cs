using UnityEngine;

public class CardView : MonoBehaviour
{
  private CardInstance _cardInstance;

  public void Init(CardInstance cardInstance)
  {
    _cardInstance = cardInstance;
  }
}