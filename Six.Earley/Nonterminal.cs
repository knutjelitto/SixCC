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

using System.Collections.Generic;
using System.Linq;

namespace Earley
{
    internal sealed class Nonterminal: Symbol
	{
		private readonly HashSet<Production> productions;

		public Nonterminal(params Production[] productions)
		{
			this.productions = new HashSet<Production>(productions);
		}

		public void Add(params Production[] productions)
		{
            this.productions.UnionWith(productions);
		}

		internal int Count
		{
			get { return productions.Count;  }
		}

		internal bool Contains(Production p)
		{
            return productions.Contains(p);
		}

		internal IEnumerable<Production> Productions
		{
			get { return productions; }
		}
	}
}
