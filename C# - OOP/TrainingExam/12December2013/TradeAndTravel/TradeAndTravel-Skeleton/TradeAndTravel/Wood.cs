namespace TradeAndTravel
{
    public class Wood : Item
    {
        const int GeneralWoodValue = 2;
        public int Sharpness { get; protected set; }

        public Wood(string name, Location location = null)
            : base(name, Wood.GeneralWoodValue, ItemType.Wood, location)
        {
        }

        public override void UpdateWithInteraction(string interaction)
        {
            base.UpdateWithInteraction(interaction);
            if (interaction == "drop")
            {
                this.Value--;
                if (this.Value < 0)
                {
                    this.Value = 0;
                }
            }
        }
    }
}
