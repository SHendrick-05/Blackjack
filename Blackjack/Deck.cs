using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.Globalization;
using System.Resources;
using System.Security.Cryptography;

namespace Blackjack
{


    public enum Suit
    {
        SPADES = 0,
        CLUBS = 1,
        HEARTS = 2,
        DIAMONDS = 3
    }

    public enum Value
    {
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING,
        ACE

    }

    public class Card
    {
        public Suit suit;
        public Value value;
        public Image image;

        public Card(Suit st, Value val, Image img)
        {
            suit = st;
            value = val;
            image = img;
        }
    }

    internal static class DeckHandler
    {
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        internal static List<Card> deck = new List<Card>();

        // Top level methods
        public static Card drawCard()
        {
            if (deck.Count >= 1)
            {
                Card result = deck[deck.Count - 1];
                deck.RemoveAt(deck.Count - 1);
                return result;
            }
            throw new NotImplementedException();
        }

        public static int getRadomNum()
        {
            byte[] result = new byte[4];
            rngCsp.GetBytes(result);
            int num = BitConverter.ToInt32(result, 0);
            return num;
        }

        public static void shuffleCards()
        {


            deck = deck.OrderBy(x => getRadomNum()).ToList();
        }

        public static void addCard(Card crd)
        {
            deck.Insert(0, crd);
        }

        // Contructor
        static DeckHandler()
        {
            ResourceManager mngr = new ResourceManager(typeof(Properties.Resources));
            ResourceSet rcst = mngr.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            var imageDict = new Dictionary<string, Image>();
            foreach (DictionaryEntry entry in rcst)
            {
                imageDict.Add(entry.Key.ToString(), (Image)entry.Value);
            }

            var Values = Enum.GetValues(typeof(Value));
            for (int i = 0; i < 4; i++)
            {
                
                foreach (Value val in Values)
                {
                    string name = Enum.GetName(typeof(Suit), i);
                    string valString = (int)val > 8 ? Enum.GetName(typeof(Value), val) : ((int)val + 2).ToString();

                    string qString = "_" + valString[0] + name[0];
                    Card crd = new Card((Suit)i, val, imageDict[qString]);
                    DeckHandler.deck.Add(crd);
                }
            }
            shuffleCards();
        }
    }

}
