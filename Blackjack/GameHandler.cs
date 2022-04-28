using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.Globalization;
using System.Resources;

namespace Blackjack
{
    public class Player
    {
        public int points;
        public List<Card> cards;
        public int cardPoints
        {
            get
            {
                int total = 0;
                foreach (Card crd in cards)
                {
                    total += GameHandler.valueFromCard(crd);
                }
                if (total > 21)
                {
                    total = 0;
                    foreach (Card crd in cards)
                    {
                        total += GameHandler.valueFromCard(crd, true);
                    }
                    return total;
                }
                else return total;
            }
        }
        public bool bust
        {
            get
            {
                return cardPoints > 21;
            }
        }
    }

    internal static class GameHandler
    {
        internal static int valueFromCard(Card crd, bool aceOne = false)
        {
            if ((int)crd.value <= 8)
                return (int)crd.value + 2;
            else if (crd.value != Value.ACE)
                return 10;
            return aceOne ? 1 : 11;
        }

        internal static bool playerTurn = true;

        internal static void Turn()
        {

        }
    }
}
