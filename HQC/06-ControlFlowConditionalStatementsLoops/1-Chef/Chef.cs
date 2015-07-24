namespace Chef
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            Bowl bowl = this.GetBowl();

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private void Cut(Potato potato)
        {
            throw new NotImplementedException();
        }

        private Bowl GetBowl()
        {
            //...
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            //...
            return new Carrot();
        }

        private Potato GetPotato()
        {
            //...
            return new Potato();
        }

        private void Cut(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }

        private void Peel(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }
    }
}
