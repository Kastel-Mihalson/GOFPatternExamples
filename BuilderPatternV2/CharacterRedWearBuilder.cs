using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternV2
{
    public class CharacterRedWearBuilder : CharacterBuilder
    {
        public Character Character = new Character();

        public override Character GetResult()
        {
            return Character;
        }

        public override void SetPants()
        {
            Character.AddElement(new RedShoes());
        }

        public override void SetShoes()
        {
            Character.AddElement(new RedTShirt());
        }

        public override void SetTShirt()
        {
            Character.AddElement(new RedPants());
        }
    }
}
