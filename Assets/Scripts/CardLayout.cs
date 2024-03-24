using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CardLayout : MonoBehaviour
{
    [SerializeField] public int _layoutId;
    [SerializeField] public Vector2 _offset;
    [SerializeField] public bool _faceUp;

    private void Update()
    {
        var cards = CardGame.GetInstance().GetCardsInLayout(_layoutId);
        for (int i = 0; i < cards.Count; i++)
        {
            cards[i].CardInstance.CardPosition = i;
            cards[i].transform.SetParent(transform);
            cards[i].transform.position = _offset * i;
            cards[i].transform.SetSiblingIndex(i);
            cards[i].Rotate(_faceUp);
        }
    }
}