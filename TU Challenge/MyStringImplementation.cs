using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
	public class MyStringImplementation
	{
		public static bool IsNullEmptyOrWhiteSpace(string input)
		{
			if (input == null || input.Length == 0) return true;
			foreach (char c in input)
			{
				if (c != ' ') return false;
			}
			return true;
		}

		public static string MixString(string a, string b)
		{
			if (IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b))
				throw new ArgumentException();

			StringBuilder stringBuilder = new StringBuilder();
			int min = (a.Length > b.Length ? b.Length : a.Length);
			int finalLength = a.Length + b.Length;

			for (int i = 0; i < min; ++i)
			{
				stringBuilder.Append(a[i]);
				stringBuilder.Append(b[i]);
			}

			if (min == a.Length)
			{
				stringBuilder.Append(b.Substring(min));
			}
			else
			{
				stringBuilder.Append(a.Substring(min));
			}

			return stringBuilder.ToString();
		}

		public static string ToLowerCase(string s)
		{
			string res = "";
			foreach (char c in s)
			{
				res += char.ToLower(c);
			}
			return res;
		}

		public static string Voyelles(string s)
		{
			string res = "";
			foreach (char c in s)
			{
				switch (c)
				{
					case 'a': case 'e': case 'i': case 'o': case 'u': case 'y':
					case 'A': case 'E': case 'I': case 'O': case 'U': case 'Y':
						if (!res.Contains(char.ToLower(c)))
							res += char.ToLower(c); break;
				}
			}
			return res;
		}

		public static string Reverse(string s)
		{
			string res = "";
			for (int i = s.Length - 1; i >= 0; i--)
			{
				res += s[i];
			}
			return res;
		}

		public static string BazardString(string s)
		{
			string res = "";
			for (int i = 0; i < s.Length; i += 2)
			{
				res += s[i];
			}
			for (int i = 1; i < s.Length; i += 2)
			{
				res += s[i];
			}
			return res;
		}

		public static string UnBazardString(string s)
		{
			string res = "";
			for (int i = 0; i < s.Length / 2; ++i)
			{
				res += s[i];
				res += s[i + s.Length / 2];
			}
			return res;
		}
	}
}
