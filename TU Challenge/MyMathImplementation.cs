using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
	public class MyMathImplementation
	{
		public static int Add(int a, int b)
		{
			return a + b;
		}

		public static bool IsMajeur(int age)
		{
			if (age < 0 || age >= 150) throw new ArgumentException();
			return age >= 18;
		}

		public static bool IsEven(int i)
		{
			return (i % 2 == 0);
		}

		public static bool IsDivisible(int a, int d)
		{
			return (a % d == 0);
		}

		public static bool IsPrimary(int a)
		{
			if (a == 1) return false;

			int i = 2;
			while (i * i <= a)
			{
				if (a % i == 0)
				{
					return false;
				}
				i++;
			}

			return true;
		}

		public static List<int> GetAllPrimary(int a)
		{
			List<int> l = new List<int>();
			for (int i = 1; i <= a; i++)
			{
				if (IsPrimary(i))
				{
					l.Add(i);
				}
			}
			return l;
		}

		public static int Power2(int a)
		{
			return a * a;
		}

		public static int Power(int a, int b)
		{
			int r = 1;
			for (int i = 0; i < b; i++)
			{
				r *= a;
			}
			return r;
		}

		public static int IsInOrder(int a, int b)
		{
			if (a < b) return 1;
			if (a > b) return -1;
			return 0;
		}

		public static int IsInOrderDesc(int a, int b)
		{
			if (a < b) return -1;
			if (a > b) return 1;
			return 0;
		}

		public static bool IsListInOrder(List<int> list)
		{
			for (int i = 0; i < list.Count() - 1; ++i)
			{
				if (IsInOrder(list[i], list[i + 1]) == -1)
				{
					return false;
				}
			}
			return true;
		}

		public static List<int> Sort(List<int> list)
		{
			return GenericSort(list, IsInOrder);
		}

		public static List<int> GenericSort(List<int> list, Func<int, int, int> compFunc)
		{
			List<int> res = new List<int>();
			res.AddRange(list);

			bool hasSwapped = true;
			while (hasSwapped)
			{
				hasSwapped = false;
				for (int i = 0; i < res.Count() - 1; i++)
				{
					if (compFunc(res[i], res[i + 1]) == -1)
					{
						hasSwapped = true;
						int temp = res[i];
						res[i] = res[i + 1];
						res[i + 1] = temp;
					}
				}
			}

			return res;
		}
	}
}
