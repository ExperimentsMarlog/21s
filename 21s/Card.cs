using System;
using System.Collections.Generic;
using System.Text;

namespace _21s
{
    public class Card
    {
        public string Description { get; protected set; }
        public int BaseWeight { get; protected set; }
        public Card (string _description, int _weight)
        {
            Description = _description;
            BaseWeight = _weight;
        }

        public virtual int GetWeight()
        {
            return BaseWeight;
        }
    }
}
