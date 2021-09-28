using System;
using System.Collections.Generic;
using System.Text;

namespace Week_4_Exercises
{
	public enum CardSuit
	{
		Diamonds,
		Hearts,
		Clubs,
		Spades
	}

	public enum CardRank
	{
		Two = 2,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Jack,
		Queen,
		King,
		Ace
	}
	class Card
	{
		public CardRank Rank { get; set; }
		public CardSuit Suit { get; set; }

		public Card(CardRank rank, CardSuit suit)
		{
			Rank = rank;
			Suit = suit;
		}

	}
}
