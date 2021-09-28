﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab_15._1.Models;
using System.Net.Http;

namespace Lab_15._1.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> DeckOfCards(string drawAgain, string deck_id/*, string card0, string card1, string card2, string card3, string card4*/)
		{
			//List<string> keep = new List<string>() { card0, card1, card2, card3, card4};
			//bool keepCard = false;
			//foreach(string card in keep)
			//{
			//	if (!string.IsNullOrEmpty(card))
			//	{
			//		keepCard = true;
			//	}
			//}
			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri("https://deckofcardsapi.com");
			var response = await client.GetAsync("/api/deck/new/shuffle");
			CardHand hand;
			if (string.IsNullOrEmpty(drawAgain))
			{
				CardDeck deck = await response.Content.ReadAsAsync<CardDeck>();
				response = await client.GetAsync($"/api/deck/{deck.Deck_ID}/draw/?count=5");
				hand = await response.Content.ReadAsAsync<CardHand>();
			}
			//else if(keepCard)
			//{
			//	response = await client.GetAsync($"/api/deck/{deck_id}/pile/keepCards/add/?cards=AS,2S");
			//}
			else
			{
				response = await client.GetAsync($"/api/deck/{deck_id}/draw/?count=5");
				hand = await response.Content.ReadAsAsync<CardHand>();
			}
			return View(hand);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}