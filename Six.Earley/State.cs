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

namespace Earley
{
	internal sealed class State
	{
		private readonly List<Item> items = new();

		internal State() { }

		internal void Add(Item item)
		{
			if (Contains(item)) throw new InvalidOperationException();

			items.Add(item);
		}

		internal bool Contains(Item item)
		{
			return items.Contains(item);
		}

        internal int Count => items.Count;

        // gets items in this state with the dot before non-terminals that
        // contain the specified production
        internal List<Item> GetItems(Production production)
		{
			List<Item> result = new();

			foreach (Item item in items)
			{
				if (!item.AtEnd &&
					item.Symbol is Nonterminal nonterminal &&
					nonterminal.Contains(production))
				{
					result.Add(item);
				}
			}

			return result;
		}

		internal Item this[int index]
		{
			get { return items[index]; }
		}

		private Item? this[Item item]
		{
			get
			{
				foreach (Item existing in items)
				{
					if (existing.Equals(item))
					{
						return existing;
					}
				}

				return null;
			}
		}

		internal Item Import(Item item)
		{
			if (Contains(item))
			{
				var existing = this[item]!;

				if (!existing.IsImportCompatible(item))
				{
                    throw new ArgumentOutOfRangeException(nameof(item));
				}

				return existing;
			}
			else
			{
				Add(item);
				return item;
			}
		}
	}
}