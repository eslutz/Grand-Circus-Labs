using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab_6._2
{
	public class CustomerOrder
	{
		private Dictionary<Product, int> _order = new Dictionary<Product, int>();
		private decimal _subtotal = 0;
		private decimal _total = 0;
		private decimal _paymentAmount;
		private decimal _change;

		public Dictionary<Product, int> Order
		{
			get { return _order; }
			private set { _order = value; }
		}

		public decimal Subtotal
		{
			get { return _subtotal; }
			private set { _subtotal = value; }
		}

		public decimal Total
		{
			get { return _total; }
			private set { _total = value; }
		}

		public decimal PayementAmount
		{
			get { return _paymentAmount; }
			private set { _paymentAmount = value; }
		}

		public decimal Change
		{
			get { return _change; }
			private set { _change = value; }
		}

		public void AddToOrder(Product item, int quantity)
		{
			if (Order.ContainsKey(item))
			{
				Order[item] += quantity;
			}
			else
			{
				Order.Add(item, quantity);
			}
		}

		public decimal SubTotal()
		{
			foreach (KeyValuePair<Product, int> item in Order)
			{
				Subtotal += decimal.Round(item.Key.Price * item.Value, 2);
			}
			return Subtotal;
		}

		public decimal GrandTotal()
		{
			Total = decimal.Round(Subtotal * 1.06m, 2);
			return Total;
		}

		public void AmountPaid(decimal paymentAmount)
		{
			PayementAmount = paymentAmount;
		}

		public decimal ChangeDue()
		{
			if (PayementAmount > Total)
			{
				Change = decimal.Round(PayementAmount - Total, 2);
				return Change;
			}
			else
			{
				return 0;
			}
		}

		public string OrderReceipt()
		{
			string receipt = "";

			receipt += $"{"Item",-40}{"Category",-12}{"Price",6}{"Qty.",6}{"Total",12}\n";
			receipt += $"{new String('*', 76)}\n";
			foreach (KeyValuePair<Product, int> item in Order)
			{
				receipt += $"{item.Key.Name,-40}{item.Key.Category,-12}{item.Key.Price,6:C}{item.Value,6}{item.Key.Price * item.Value,12:C}\n";
			}
			receipt += $"{new String('-', 30)}\n";
			receipt += $"{"Subtotal:",-20}{Subtotal:C}\n";
			receipt += $"{"Total (6% tax):",-20}{Total:C}\n";
			receipt += $"{"Amount Paid:",-20}{PayementAmount:C}\n";
			receipt += $"{"Change Due:",-20}{Change:C}";
			return receipt;
		}
	}
}
