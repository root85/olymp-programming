using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;


public class TheBrickTowerEasyDivTwo
{
	bool[] was = new bool[100000];

	public int find(int redCount, int redHeight, int blueCount, int blueHeight)
	{
		cnt(0, new int[] { redHeight, blueHeight }, new int[] { redCount, blueCount });
		cnt(1, new int[] { redHeight, blueHeight }, new int[] { redCount, blueCount });

		int r = 0;
		for (int i = 0; i < was.Length; i++)
			if (was[i]) r++;
		return r;
	}

	void cnt(int s, int[] h, int[] cnt)
	{
		int[] c = new int[2];
		int curh = 0;
		while (c[s] < cnt[s])
		{
			c[s]++;
			curh += h[s];
			was[curh] = true;
			s = 1 - s;
		}
	}

	// BEGIN KAWIGIEDIT TESTING
	// Generated by KawigiEdit 2.1.4 (beta) modified by pivanof
	#region Testing code generated by KawigiEdit
	[STAThread]
	private static Boolean KawigiEdit_RunTest(int testNum, int p0, int p1, int p2, int p3, Boolean hasAnswer, int p4)
	{
		Console.Write("Test " + testNum + ": [" + p0 + "," + p1 + "," + p2 + "," + p3);
		Console.WriteLine("]");
		TheBrickTowerEasyDivTwo obj;
		int answer;
		obj = new TheBrickTowerEasyDivTwo();
		DateTime startTime = DateTime.Now;
		answer = obj.find(p0, p1, p2, p3);
		DateTime endTime = DateTime.Now;
		Boolean res;
		res = true;
		Console.WriteLine("Time: " + (endTime - startTime).TotalSeconds + " seconds");
		if (hasAnswer)
		{
			Console.WriteLine("Desired answer:");
			Console.WriteLine("\t" + p4);
		}
		Console.WriteLine("Your answer:");
		Console.WriteLine("\t" + answer);
		if (hasAnswer)
		{
			res = answer == p4;
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

		int p0;
		int p1;
		int p2;
		int p3;
		int p4;

		// ----- test 0 -----
		p0 = 1;
		p1 = 2;
		p2 = 3;
		p3 = 4;
		p4 = 4;
		all_right = KawigiEdit_RunTest(0, p0, p1, p2, p3, true, p4) && all_right;
		// ------------------

		// ----- test 1 -----
		p0 = 4;
		p1 = 4;
		p2 = 4;
		p3 = 7;
		p4 = 12;
		all_right = KawigiEdit_RunTest(1, p0, p1, p2, p3, true, p4) && all_right;
		// ------------------

		// ----- test 2 -----
		p0 = 7;
		p1 = 7;
		p2 = 4;
		p3 = 4;
		p4 = 13;
		all_right = KawigiEdit_RunTest(2, p0, p1, p2, p3, true, p4) && all_right;
		// ------------------

		// ----- test 3 -----
		p0 = 47;
		p1 = 47;
		p2 = 47;
		p3 = 47;
		p4 = 94;
		all_right = KawigiEdit_RunTest(3, p0, p1, p2, p3, true, p4) && all_right;
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