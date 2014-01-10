using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;


public class BinPackingEasy
{
	public int minBins(int[] item)
	{
		int res = 0;
		int n = item.Length;

		List<int> l = new List<int>(item);
		l.Sort();
		for (int i = 0;i < l.Count;i++)
			if (l[i] > 300-101)
			{
				res++;
				l.RemoveAt(i);
				i--;
			}
			
		int c = l.Count;

		bool[] t = new bool[c];
		while (true)
		{
			int max = 0;
			int mi, mj;
			mi = mj = -1;
			for (int i = 0;i < c;i++)
			{
				if (t[i]) continue;
				for (int j = 0;j < c;j++)
				{
					if (i == j || t[j]) continue;
					int s = l[i] + l[j];
					if (s <= 300 && s > max)
					{
						mi = i;
						mj = j;
						max = s;
					}
				}
			}
			
			if (max == 0)
				break;
			res++;
			t[mi] = t[mj] = true;
		}
		//Console.WriteLine("Before {0}", res);

		for (int i = 0;i < c;i++)
			if (!t[i]) res++;
		
		return res;
	}

	// BEGIN KAWIGIEDIT TESTING
	// Generated by KawigiEdit 2.1.4 (beta) modified by pivanof
	#region Testing code generated by KawigiEdit
	[STAThread]
	private static Boolean KawigiEdit_RunTest(int testNum, int[] p0, Boolean hasAnswer, int p1) {
		Console.Write("Test " + testNum + ": [" + "{");
		for (int i = 0; p0.Length > i; ++i) {
			if (i > 0) {
				Console.Write(",");
			}
			Console.Write(p0[i]);
		}
		Console.Write("}");
		Console.WriteLine("]");
		BinPackingEasy obj;
		int answer;
		obj = new BinPackingEasy();
		DateTime startTime = DateTime.Now;
		answer = obj.minBins(p0);
		DateTime endTime = DateTime.Now;
		Boolean res;
		res = true;
		Console.WriteLine("Time: " + (endTime - startTime).TotalSeconds + " seconds");
		if (hasAnswer) {
			Console.WriteLine("Desired answer:");
			Console.WriteLine("\t" + p1);
		}
		Console.WriteLine("Your answer:");
		Console.WriteLine("\t" + answer);
		if (hasAnswer) {
			res = answer == p1;
		}
		if (!res) {
			Console.WriteLine("DOESN'T MATCH!!!!");
		} else if ((endTime - startTime).TotalSeconds >= 2) {
			Console.WriteLine("FAIL the timeout");
			res = false;
		} else if (hasAnswer) {
			Console.WriteLine("Match :-)");
		} else {
			Console.WriteLine("OK, but is it right?");
		}
		Console.WriteLine("");
		return res;
	}
	public static void Main(string[] args) {
		Boolean all_right;
		all_right = true;
		
		int[] p0;
		int p1;
		
		// ----- test 0 -----
		p0 = new int[]{150,150,150,150,150};
		p1 = 3;
		all_right = KawigiEdit_RunTest(0, p0, true, p1) && all_right;
		// ------------------
		
		// ----- test 1 -----
		p0 = new int[]{130,140,150,160};
		p1 = 2;
		all_right = KawigiEdit_RunTest(1, p0, true, p1) && all_right;
		// ------------------
		
		// ----- test 2 -----
		p0 = new int[]{101,101,101,101,101,101,101,101,101};
		p1 = 5;
		all_right = KawigiEdit_RunTest(2, p0, true, p1) && all_right;
		// ------------------
		
		// ----- test 3 -----
		p0 = new int[]{101,200,101,101,101,101,200,101,200};
		p1 = 6;
		all_right = KawigiEdit_RunTest(3, p0, true, p1) && all_right;
		// ------------------
		
		// ----- test 4 -----
		p0 = new int[]{123,145,167,213,245,267,289,132,154,176,198};
		p1 = 8;
		all_right = KawigiEdit_RunTest(4, p0, true, p1) && all_right;
		// ------------------
		
		if (all_right) {
			Console.WriteLine("You're a stud (at least on the example cases)!");
		} else {
			Console.WriteLine("Some of the test cases had errors.");
		}
	}
	#endregion
	// END KAWIGIEDIT TESTING
}
//Powered by KawigiEdit 2.1.4 (beta) modified by pivanof!