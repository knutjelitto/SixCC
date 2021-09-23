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
using System.Linq;
using System.Text;

namespace Earley
{
	internal sealed class Terminal: Symbol
	{
		private readonly HashSet<int> cs = new();

		public static readonly Terminal Eof = new(-1);

		private static int[] CharVToIntV(char[] cs)
		{
			return Array.ConvertAll<char, int>(cs, delegate(char ch) { return ch; });
		}


		private Terminal(params int[] cs)
		{
			this.cs.UnionWith(cs);
		}

		public Terminal(params char[] cs)
			: this(CharVToIntV(cs))
		{ 
		}

		public Terminal(string cs)
			: this(cs.ToCharArray())
        {
        }

		public override bool Equals(object? obj)
		{
			if (obj is Terminal other && other.Count == Count)
			{
				foreach (int c in cs)
				{
					if (!other.Contains(c)) return false;
				}

				return true;
			}
			else
			{
				return false;
			}
		}

		public override int GetHashCode()
		{
			var hash = new HashCode(); ;

			foreach (int c in cs)
			{
				hash.Add(c);
			}

			return hash.ToHashCode();
		}

		internal bool Contains(int ch)
		{
			return cs.Contains(ch);
		}

		internal int Count
		{
			get { return cs.Count; }
		}

		public override string ToString()
		{
			StringBuilder accum = new();

			IEnumerable<int> ics = this.cs;

			var eof = string.Empty;
			if (ics.Contains(-1))
			{
				eof = "(EOF)";
				ics = ics.Where(i => i != -1);
			}

			var s = string.Join(string.Empty, ics.Select(i => (char)i).OrderBy(c => c));
			
			return $"{eof}{s}";
		}
	}
}