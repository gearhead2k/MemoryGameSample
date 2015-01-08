namespace MemoryGame.Engine.Models
{
    using System.Collections.Generic;

    public class Board
    {
        private List<Card> _pieces = new List<Card>(); 
        public List<Card> Pieces
        {
            get { return this._pieces; }
            set { this._pieces = value; }
        }

        public Board()
        {
            int imgIndex = 1;
            for (int i = 1; i <= 30; i++)
            {
                if (this.IsOdd(i))
                    this._pieces.Add(new Card()
                    {
                        Id = i,
                        Pair = i + 1,
                        Name = "card-" + i.ToString(),
                        Image = string.Format("/content/img/{0}.png", imgIndex)
                    });
                else
                {
                    this._pieces.Add(new Card()
                    {
                        Id = i,
                        Pair = i - 1,
                        Name = "card-" + i.ToString(),
                        Image = string.Format("/content/img/{0}.png", imgIndex)
                    });
                    imgIndex++;
                }
            }
            this._pieces.Shuffle();

        }

        private bool IsOdd(int i)
        {
            return i%2 != 0;
        }
    }
}