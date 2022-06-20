using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section20Observer
{
    public class Game
    {
        public event EventHandler ResetRatAttack;
        public event EventHandler IncludeRatInAttackCalculation;
        public event EventHandler IncrementAttack;

        public void AddRatToEventHandlers(Rat rat)
        {
            this.ResetRatAttack += rat.Game_ResetRatAttack;
            this.IncludeRatInAttackCalculation += rat.Game_IncludeRatInAttackCalculation;
            this.IncrementAttack += rat.Game_IncrementAttack;
        }

        public void RemoveRatFromEventHandlers(Rat rat)
        {
            this.ResetRatAttack -= rat.Game_ResetRatAttack;
            this.IncludeRatInAttackCalculation -= rat.Game_IncludeRatInAttackCalculation;
            this.IncrementAttack -= rat.Game_IncrementAttack;
        }

        public void RatCreatedInGame(Rat rat)
        {
            ResetRatAttack?.Invoke(rat, EventArgs.Empty);

            CalculateRatAttack(rat);
        }

        public void CalculateRatAttack(Rat rat)
        {
            IncludeRatInAttackCalculation?.Invoke(rat, EventArgs.Empty);
        }

        public void IncrementRatAttack(Rat rat)
        {
            IncrementAttack?.Invoke(rat, EventArgs.Empty);
        }

        public void RatDiedInGame(Rat rat)
        {
            ResetRatAttack?.Invoke(rat, EventArgs.Empty);

            CalculateRatAttack(rat);
        }
    }

    public class Rat : IDisposable
    {
        public int Attack = 1;
        private Game game;

        public Rat(Game game)
        {
            this.game = game;
            this.game.AddRatToEventHandlers(this);

            this.game.RatCreatedInGame(this);
        }

        public void Game_ResetRatAttack(object sender, EventArgs e)
        {
            Attack = 0;
        }

        public void Game_IncludeRatInAttackCalculation(object sender, EventArgs e)
        {
            this.game.IncrementRatAttack(this);
        }

        public void Game_IncrementAttack(object sender, EventArgs e)
        {
            Attack++;
        }

        public void Dispose()
        {
            this.game.RemoveRatFromEventHandlers(this);
                
            this.game.RatDiedInGame(this);
        }
    }
}
