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

namespace Earley
{
    internal sealed class Item
	{
		private readonly Production production;
		private readonly int dot;
        private readonly State parent;
		private readonly List<object>? derivations;
		private readonly Item? prevItem;

		internal Item(Production production, State parent)
			: this(production, 0, parent, null) { }

		private Item(Production production, int dot, State parent, Item? prevItem)
		{
			this.production = production;
			this.dot = dot;
			this.parent = parent ?? throw new ArgumentNullException(nameof(parent));
			this.prevItem = prevItem;
			this.derivations = dot == 0 ? null : new List<object>();
		}

		public override bool Equals(object? obj)
		{
			return obj is Item other &&
				   other.production == production &&
				   other.dot == dot &&
				   other.parent == parent &&
				   other.prevItem == prevItem;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(parent, production, prevItem, dot);
		}

		internal void Add(int ch)
		{
			if (AtStart || !(prevItem!.Symbol is Terminal terminal))
			{
				throw new InvalidOperationException();
			}

			if (!terminal.Contains(ch))
			{
				throw new ArgumentOutOfRangeException(nameof(ch));
			}

			derivations!.Add(ch);
		}

		internal void Add(Item it)
		{
			if (AtStart || !(prevItem!.Symbol is Nonterminal nonterminal))
			{
				throw new InvalidOperationException();
			}

			if (!nonterminal.Contains(it.production))
			{
				throw new ArgumentOutOfRangeException(nameof(it));
			}

			derivations!.Add(it);
		}

        private bool AtStart => dot == 0;

        internal bool AtEnd => dot == production.Symbols.Count;

        internal Item NextItem
		{
			get
			{
				if (AtEnd)
				{
					throw new InvalidOperationException();
				}
				return new Item(production, dot + 1, parent, this);
			}
		}

		internal State Parent
		{
			get { return parent; }
		}

		internal Production Production
		{
			get { return production; }
		}

		internal List<object> Reduce()
		{
            if (!AtEnd || production is not Reduction reduction)
            {
                throw new InvalidOperationException();
            }

            List<object> result = new();

			foreach (object[] args in ReduceWorker())
			{
				result.Add(reduction.Apply(args));
			}

			return result;
		}

		// reduces all the derivations for *this* symbol
		private List<object> ReduceSymbol()
		{
			if (AtStart) throw new InvalidOperationException();
			Debug.Assert(prevItem != null);

			List<object> result = new();

			if (prevItem.Symbol is Terminal)
			{
				result.AddRange(derivations!);
			}
			else if (prevItem.Symbol is Nonterminal)
			{
				foreach (Item item in derivations!)
				{
					result.AddRange(item.Reduce());
				}
			}

			return result;
		}

		private List<object[]> ReduceWorker()
		{
			List<object[]> result = new();

			if (production.Symbols.Count == 0)
			{
				result.Add(Array.Empty<object>());
			}
			else if (prevItem!.AtStart)
			{
				foreach (object value in ReduceSymbol())
				{
					object[] args = new object[production.Symbols.Count];
					args[0] = value;
					result.Add(args);
				}
			}
			else
			{
				List<object> symbolReductions = ReduceSymbol();

				foreach (object[] prefix in prevItem!.ReduceWorker())
				{
					foreach (object value in symbolReductions)
					{
						object[] args = (prefix.Clone() as object[])!;
						args[prevItem.dot] = value;
						result.Add(args);
					}
				}
			}

			return result;
		}

		internal Symbol Symbol
		{
			get
			{
				if (AtEnd)
				{
					throw new InvalidOperationException();
				}
				return production.Symbols[dot];
			}
		}

		// whether the other item is empty and just being used as a key,
		// or whether it has a different previous item, already has
		// derivations, etc. See State::Import.
		internal bool IsImportCompatible(Item other)
		{
            return Equals(other) &&
				   ((other.derivations == null && derivations == null) ||
				    other.derivations!.Count == 0);
		}
	}
}
