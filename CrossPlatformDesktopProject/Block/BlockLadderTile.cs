namespace Sprint2
{
    public class BlockLadderTile : AbstractBlock
    {
        public BlockLadderTile()
        {
            Sprite = BlockSpriteFactory.Instance.CreateSpriteLadderTile();
            Position = Constant.BlockStartPosition;
        }
        public override Enumerations.GameObjectType GameObjectType { get; set; } = Enumerations.GameObjectType.FloorTile;




    }
}