using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;


public class IncrementAndDoubling
{
	int[] D;
	int[] S;

	public int getMin(int[] desiredArray)
	{
		int res = int.MaxValue;
		int min = int.MaxValue;

		foreach (var x in desiredArray)
			min = Math.Min(x, min);

		int lim = min;
		//for (int lim = 0; lim <= min; lim++)
		{
			S = new int[min + 1];
			D = new int[min + 1];
			for (int i = 0; i < D.Length; i++)
				D[i] = -1;

			int sum = 0;
			foreach (var x in desiredArray)
				sum += x - lim;

			sum += minf(min, desiredArray.Length);
			res = Math.Min(sum, res);
		}

		return res;
	}

	int minf(int x, int n)
	{
		if (x == 0)
			return 0;

		if (D[x] != -1)
			return D[x];

		int res = minf(x - 1, n) + n;
		if (x % 2 == 0)
		{
			int cur = minf(x / 2, n) + 1;
			res = Math.Min(cur, res);
		}
		D[x] = res;

		return res;
	}

	// BEGIN KAWIGIEDIT TESTING
	// Generated by KawigiEdit 2.1.4 (beta) modified by pivanof
	#region Testing code generated by KawigiEdit
	[STAThread]
	private static Boolean KawigiEdit_RunTest(int testNum, int[] p0, Boolean hasAnswer, int p1)
	{
		Console.Write("Test " + testNum + ": [" + "{");
		for (int i = 0; p0.Length > i; ++i)
		{
			if (i > 0)
			{
				Console.Write(",");
			}
			Console.Write(p0[i]);
		}
		Console.Write("}");
		Console.WriteLine("]");
		IncrementAndDoubling obj;
		int answer;
		obj = new IncrementAndDoubling();
		DateTime startTime = DateTime.Now;
		answer = obj.getMin(p0);
		DateTime endTime = DateTime.Now;
		Boolean res;
		res = true;
		Console.WriteLine("Time: " + (endTime - startTime).TotalSeconds + " seconds");
		if (hasAnswer)
		{
			Console.WriteLine("Desired answer:");
			Console.WriteLine("\t" + p1);
		}
		Console.WriteLine("Your answer:");
		Console.WriteLine("\t" + answer);
		if (hasAnswer)
		{
			res = answer == p1;
		}
		if (!res)
		{
			Console.WriteLine("DOESN'T MATCH!!!!");
		}
		else if ((endTime - startTime).TotalSeconds >= 2)
		{
			Console.WriteLine("FAIL the timeout");
			res = false;
		}
		else if (hasAnswer)
		{
			Console.WriteLine("Match :-)");
		}
		else
		{
			Console.WriteLine("OK, but is it right?");
		}
		Console.WriteLine("");
		return res;
	}
	public static void Main(string[] args)
	{
		Boolean all_right;
		all_right = true;

		int[] p0;
		int p1;

		// ----- test 0 -----
		p0 = new int[] { 2, 1 };
		p1 = 3;
		all_right = KawigiEdit_RunTest(0, p0, true, p1) && all_right;
		// ------------------

		// ----- test 1 -----
		p0 = new int[] { 16, 16, 16 };
		p1 = 7;
		all_right = KawigiEdit_RunTest(1, p0, true, p1) && all_right;
		// ------------------

		// ----- test 2 -----
		p0 = new int[] { 100 };
		p1 = 9;
		all_right = KawigiEdit_RunTest(2, p0, true, p1) && all_right;
		// ------------------

		// ----- test 3 -----
		p0 = new int[] { 0, 0, 1, 0, 1 };
		p1 = 2;
		all_right = KawigiEdit_RunTest(3, p0, true, p1) && all_right;
		// ------------------

		// ----- test 4 -----
		p0 = new int[] { 123, 234, 345, 456, 567, 789 };
		p1 = 40;
		all_right = KawigiEdit_RunTest(4, p0, true, p1) && all_right;
		// ------------------

		// ----- test 5 -----
		p0 = new int[] { 7, 5, 8, 1, 8, 6, 6, 5, 3, 5, 5, 2, 8, 9, 9, 4, 6, 9, 4, 4, 1, 9, 9, 2, 8, 4, 7, 4, 8, 8, 6, 3, 9, 4, 3, 4, 5, 1, 9, 8, 3, 8, 3, 7, 9, 3, 8, 4, 4, 7 };
		p1 = 84;
		all_right = KawigiEdit_RunTest(5, p0, true, p1) && all_right;
		// ------------------

		if (all_right)
		{
			Console.WriteLine("You're a stud (at least on the example cases)!");
		}
		else
		{
			Console.WriteLine("Some of the test cases had errors.");
		}
	}
	#endregion
	// END KAWIGIEDIT TESTING
}
//Powered by KawigiEdit 2.1.4 (beta) modified by pivanof!
