using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardGame
{
    private static CardGame _instance;

    public static CardGame GetInstance()
    {
        return _instance ??= new CardGame();
    }
    
    private CardGame() {}

    private Dictionary<CardInstance, CardView> _dictionary = new();
    private List<CardAsset> StartCardAssets = new();
    private GameObject _prefab;

    public void InitPrefab(GameObject prefab)
    {
        _prefab = prefab;
    }

    private void CreateCardView(CardInstance cardInstance)
    {
        GameObject card = Object.Instantiate(_prefab);
        CardView cardView = card.GetComponent<CardView>();
        cardView.Init(cardInstance);
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
        for (int i = 0; i < StartCardAssets.Count; ++i)
        {
            CreateCard(StartCardAssets[i], i % 3);
        }
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