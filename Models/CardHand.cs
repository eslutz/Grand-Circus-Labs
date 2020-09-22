using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_15._1.Models
{
	public class CardHand
	{
		public bool Success { get; set; }
		public CardDetail[] Cards { get; set; }
		public string Deck_ID { get; set; }
		public int Remaining { get; set; }
	}
}