using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializacja_studia
{
     
    class Player
    {
        [JsonProperty("name")]
        private string name;
        [JsonProperty("healthPoints")]
        private double healthPoints;
        [JsonProperty("magicPoints")]
        private double magicPoints;
        private double criticalDamage=1.0,damage;
        [JsonProperty("level")]
        private int level;
        [JsonProperty("statPoints")]
        private int statPoints;
        [JsonProperty("expPoints")]
        private int expPoints;
        [JsonProperty("expToLevelPoints")]
        private int expToLevelPoints;
        [JsonProperty("strong")]
        private int strong;
        [JsonProperty("intelligence")]
        private int intelligence;
        [JsonProperty("dexterity")]
        private int dexterity;
 
        public Player(string name)
        {
            this.name = name;
            this.level = 1;
            this.statPoints = 0;
            this.healthPoints = Math.Round(100.00, 2);
            this.magicPoints = Math.Round(100.00, 2);
            this.expPoints = 0;
            this.expToLevelPoints = 50;
            this.strong = 4;
            this.intelligence = 2;
            this.dexterity = 3;


        }
        #region Getters/Setters
        public string getPlayerName()
        {
            return this.name;
        }
        public int getPlayerLevel()
        {
            return this.level;
        }
        public int getPlayerStatPoint()
        {
            return this.statPoints;
        }
        public int getPlayerExpPoint()
        {
            return this.expPoints;
        }
        public int getPlayerExpToLevelPoints()
        {
            return this.expToLevelPoints;
        }
        public int getPlayerStrong()
        {
            return this.strong;
        }
        public int getPlayerIntelligence()
        {
            return this.intelligence;
        }
        public int getPlayerDexterity()
        {
            return this.dexterity;
        }
        public double getDamage()
        {
            return this.damage;
        }
        public void setPlayerName(string value)
        {
            this.name = value;
        }
        public void setPlayerLevel(int value)
        {
            this.level = value;
        }
        public void setPlayerStatPoint(int value)
        {
            this.statPoints = value;
        }
        public void setPlayerExpPoint(int value)
        {
            this.expPoints = value;
        }
        public void setPlayerExpToLevelPoints(int value)
        {
            this.expToLevelPoints = value;
        }
        public void setPlayerStrong(int value)
        {
            this.strong = value;
        }
        public void setPlayerIntelligence(int value)
        {
            this.intelligence = value;
        }
        public void setPlayerDexterity(int value)
        {
            this.dexterity = value;
        }
        public double getHealthPoints()
        {
            return Math.Round(this.healthPoints, 2); ;

        }
        public void getHit(double damage)
        {
            this.healthPoints = Math.Round(this.healthPoints - damage, 2);
        }
        #endregion

        public void attack(ref Wolf w)
        {
            Random rand = new Random();
            double criticalAtak = rand.NextDouble();
            double damge;
            if (criticalAtak > criticalDamage)
                damge = 1.2 * this.strong + criticalAtak * this.dexterity;
            else
                damge = 1.2 * this.strong + criticalAtak * this.dexterity + this.level;

            if (w.getHealthPoints() <= damge)
                damge = w.getHealthPoints();

            w.getHit(damge);
            this.damage = damge;

        }
        public void magicAtack(ref Wolf w)
        {
            Random rand = new Random();
            double criticalAtak = rand.NextDouble();
            double damge;
            if (criticalAtak > criticalDamage)
                damge = 1.2 * this.intelligence + criticalAtak * this.dexterity;
            else
                damge = 1.2 * this.intelligence + criticalAtak * this.dexterity + this.level;

            if (w.getHealthPoints() <= damge)
            { 
                damge = w.getHealthPoints();
            }


            this.magicPoints = Math.Round(this.magicPoints - 15.00, 2); 
            w.getHit(damge);
            this.damage = damge;

        }
        public void checkLevelUp()
        {

            if (this.expPoints >= this.expToLevelPoints)
            {
                int nextExptToLevel = (this.level * 50) + 3;
                this.expPoints -= this.expToLevelPoints;
                this.level++;
                this.statPoints += 5;
                this.expToLevelPoints = nextExptToLevel;
                this.healthPoints = 100.00;
            }
        }
    }
}
