using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
        public int FinalScore = 0;
        public int[] rolls = new int[23];

        public int cnt = 0;
        public void Roll(int pins)
        {
            rolls[cnt] = pins;
            if (cnt % 2 == 0 && pins == 10)                 //placing values in array per roll
            {
                if (cnt == 20)
                {
                    cnt++;
                }
                if (cnt == 21)
                {}
                else
                {
                    rolls[cnt + 1] = 0;
                    cnt = cnt + 1;
                }
            }
            else
            {
                cnt++;
            }
            
        }

        public int GetScore()                        //calculating intermediate score
        {
             FinalScore = FinalScore + rolls[cnt] + rolls[cnt + 1];
             return FinalScore;
        }

        public int GetFinalScore()
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0 && rolls[i] == 10)               //calculating score for strikes
                {
                    FinalScore = FinalScore + rolls[i] + rolls[i+2];
                    if (rolls[i+2] == 10)
                        FinalScore = FinalScore + rolls[i + 4];
                    FinalScore = FinalScore + rolls[i+3];
                }

                else if (rolls[i] + rolls[i+1] == 10)           //calculating score for spares
                {
                    FinalScore = FinalScore + rolls[i] + rolls[i + 1] + rolls[i + 2];
                }
                else
                {
                    FinalScore = FinalScore + rolls[i] + rolls[i + 1];
                }
                i = i + 1;
            }
           return FinalScore;
        }
     }  
}
