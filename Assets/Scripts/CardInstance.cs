public class CardInstance
{
  public int CardPosition;
  public int LayoutId;

  public CardInstance(CardAsset cardAsset)
  {
    CardAsset = cardAsset;
  }

  public CardAsset CardAsset { get; }

  public void MoveToLayout(int layoutId)
  {
    LayoutId = layoutId;
  }
}