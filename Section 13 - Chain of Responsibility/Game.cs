using System;
using System.Collections.Generic;

namespace Section13ChainOfResponsibility
{
    public abstract class Creature
    {
        protected string name;
        protected int baseAttack;
        protected int baseDefense;

        public int Attack
        {
            get
            {
                return CalculateAttack();
            }

            set
            {
                baseAttack = value;
            }
        }
        public int Defense
        {
            get
            {
                return CalculateDefense();
            }

            set
            {
                baseDefense = value;
            }
        }

        protected virtual int CalculateAttack()
        {
            return 0;
        }
        protected virtual int CalculateDefense()
        {
            return 0;
        }

        public virtual int GetAttackBonus()
        {
            return 0;
        }

        public virtual int GetDefenseBonus()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{name}, Attack: {Attack}, Defense: {Defense}";
        }
    }

    public class Goblin : Creature
    {
        protected Game game;
        public Goblin(Game game)
        {
            this.name = "Goblin";
            this.game = game;
            this.baseAttack = 1;
            this.baseDefense = 1;
        }

        protected override int CalculateAttack()
        {
            int attack = this.baseAttack;

            foreach (Creature creature in this.game.Creatures)
            {
                if (Object.ReferenceEquals(creature, this)) continue;

                attack += creature.GetAttackBonus();
            }

            return attack;
        }

        protected override int CalculateDefense()
        {
            int defense = this.baseDefense;

            foreach (Creature creature in this.game.Creatures)
            {
                if (Object.ReferenceEquals(creature, this)) continue;

                defense += creature.GetDefenseBonus();
            }

            return defense;
        }

        public override int GetAttackBonus()
        {
            return 0;
        }

        public override int GetDefenseBonus()
        {
            return 1;
        }
    }

    public class GoblinKing : Goblin
    {
        public GoblinKing(Game game) : base(game)
        {
            this.name = "Goblin King";
            this.baseAttack = 3;
            this.baseDefense = 3;
        }

        public override int GetAttackBonus()
        {
            return 1;
        }
    }

    public class Game
    {
        public IList<Creature> Creatures = new List<Creature>();
    }
}
