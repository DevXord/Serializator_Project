using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializacja_studia
{
    class Wolf
    {
        private int level, strong;
        private double helathPoints, criticalDamage = 1.0,damage;
        public Wolf(int level, double helathPoints, int strong)
        {
            this.level = level;
            this.helathPoints = Math.Round(helathPoints, 2);
            this.strong = strong;
            this.criticalDamage -= (this.level / 100);
        }
        #region Getters/Setters
        public int getWolflevel()
        {
            return this.level;
        }
        public double getHealthPoints()
        {
            return Math.Round(this.helathPoints, 2); ;

        }
        public void getHit(double damage)
        {
            this.helathPoints = Math.Round(this.helathPoints - damage, 2);
        }
        public double getDamage()
        {
            return this.damage;
        }
        public int getWolfstrong()
        {
            return this.strong;
        }
        public void setWolflevel(int value)
        {
            this.level = value;
        }
        public void setWolfhelathPoints(int value)
        {
            this.helathPoints = value;
        }
        public void setWolfstrong(int value)
        {
            this.strong = value;
        }
        #endregion
        public void attackWolf(ref Player p)
        {
            Random rand = new Random();
            double criticalAtak = rand.NextDouble();
            double damge;
            if (criticalAtak > criticalDamage)
                 damge = 1.2 * this.strong + criticalAtak;
            else
                 damge = 1.2 * this.strong + criticalAtak * this.level;

            if (p.getHealthPoints() <= damge)
                damge = p.getHealthPoints();

            p.getHit(damge);
            this.damage = damge;
        }
    }
}
