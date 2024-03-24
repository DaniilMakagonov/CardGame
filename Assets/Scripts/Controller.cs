using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
  [SerializeField] private List<CardAsset> _startCardAssets;
  private void Start()
  {
    CardGame game = CardGame.GetInstance();
    game.StartCardAssets = _startCardAssets;
    game.StartGame();
  }
}