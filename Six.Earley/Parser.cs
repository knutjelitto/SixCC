// Copyright 2004 Dominic Cooney. All Rights Reserved.

/*
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Earley
{
    public sealed class Parser
	{
		private readonly Reduction start;

		internal Parser(Reduction start)
		{
			if (start.Symbols.Count == 0 || start.Symbols[start.Symbols.Count - 1] != Terminal.Eof)
			{
				throw new ArgumentOutOfRangeException(nameof(start));
			}

			this.start = start;
		}

		public IList<object> Parse(string input)
		{
			return Parse(new StringReader(input));
		}

		private IList<object> Parse(TextReader input)
		{
			State? initial = new();
			initial.Add(new Item(start, initial));

			State current = initial;
			State next = new();

			do
			{
				Dictionary<Production, List<Item>> completedNullable = new();

				for (int i = 0; i < current.Count; i++)
				{
					Item item = current[i];

					if (!item.AtEnd)
                    {
						if (item.Symbol is Nonterminal)
                        {
							Predictor(current, item, completedNullable);
						}
						else if (item.Symbol is Terminal)
                        {
							Scanner(item, next, input.Peek());
						}
						else
                        {
							throw new InvalidOperationException();
                        }
					}
					else
                    {
						Completer(current, item, completedNullable);
					}
				}

				current = next;
				next = new State();
			}
			while (input.Read() != -1 && current.Count > 0);

			if (current.Count == 1 &&
				current[0].AtEnd &&
				current[0].Production == start &&
				current[0].Parent == initial)
			{
				return current[0].Reduce();
			}
			else
			{
				return new List<object>();
			}
		}

		private void Predictor(State state, Item item, Dictionary<Production, List<Item>> completedNullable)
		{
			Debug.Assert(!item.AtEnd && item.Symbol is Nonterminal);
			
			Nonterminal nonterminal = (item.Symbol as Nonterminal)!;

            foreach (Production p in nonterminal.Productions)
			{
				Item newItem = new(p, state);

				if (!state.Contains(newItem))
				{
					state.Add(newItem);
					ShiftCompletedNullable(state, newItem, completedNullable);
				}
			}
		}

		private static void Scanner(Item item, State next, int character)
		{
			Debug.Assert(!item.AtEnd && item.Symbol is Terminal);

			var terminal = (item.Symbol as Terminal)!;

			if (terminal.Contains(character))
			{
                var newItem = item.NextItem;
				newItem.Add(character);
				next.Add(newItem);
			}
		}

		private void Completer(State state, Item item, Dictionary<Production, List<Item>> completedNullable)
		{
			Debug.Assert(item.AtEnd);

			if (item.Parent == state)
			{
				// completed a nullable item

				if (!completedNullable.ContainsKey(item.Production))
				{
					completedNullable[item.Production] = new List<Item>();
				}

				completedNullable[item.Production].Add(item);
			}

			foreach (Item parentItem in item.Parent.GetItems(item.Production))
			{
				Item newItem = state.Import(parentItem.NextItem);
				newItem.Add(item);
				ShiftCompletedNullable(state, newItem, completedNullable);
			}
		}

		// When an item is added to the current state, any nullable
		// productions that have already been completed need to be
		// added to the new item
		private void ShiftCompletedNullable(
			State state,
			Item item,
			Dictionary<Production, List<Item>> completedNullable)
		{
			if (!item.AtEnd && item.Symbol is Nonterminal nonterminal)
			{
				Item? nextItem = null;

				foreach (Production p in completedNullable.Keys)
				{
					if (nonterminal.Contains(p))
					{
						if (nextItem == null)
						{
							nextItem = state.Import(item.NextItem);
						}

						foreach (Item nullableItem in completedNullable[p])
						{
							nextItem.Add(nullableItem);
						}
					}
				}

				if (nextItem != null)
				{
					ShiftCompletedNullable(state, nextItem, completedNullable);
				}
			}
		}
	}
}