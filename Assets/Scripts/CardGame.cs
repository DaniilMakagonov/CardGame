using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardGame
{
  private static CardGame _instance;

  private readonly Dictionary<CardInstance, CardView> _dictionary = new();
  private GameObject _prefab;
  public int HandCapacity = 3;
  public List<CardAsset> StartCardAssets;

  private CardGame()
  {
  }

  public static CardGame GetInstance()
  {
    return _instance ??= new CardGame();
  }

  public void InitPrefab(GameObject prefab)
  {
    _prefab = prefab;
  }

  private void CreateCardView(CardInstance cardInstance)
  {
    GameObject card = Object.Instantiate(_prefab);
    CardView cardView = card.GetComponent<CardView>();
    cardView.Init(cardInstance);
    Object.Instantiate(cardView.CardInstance.CardAsset.Sprite, card.transform, false);
    _dictionary[cardInstance] = cardView;
  }

  private void CreateCard(CardAsset cardAsset, int layoutId)
  {
    CardInstance cardInstance = new(cardAsset);
    CreateCardView(cardInstance);
    cardInstance.MoveToLayout(layoutId);
  }

  public void StartGame()
  {
    for (int j = 0; j < 3; j++)
    for (int i = 0; i < StartCardAssets.Count; ++i)
      CreateCard(StartCardAssets[i], (i + j) % 2);
  }

  public List<CardView> GetCardsInLayout(int layoutId)
  {
    return (
      from cardInstance in _dictionary.Keys
      where cardInstance.LayoutId == layoutId
      select _dictionary[cardInstance]
    ).ToList();
  }
}