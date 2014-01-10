using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;


public class FoxAndClassroom
{
	public string ableTo(int n, int m)
	{
		for (int i = 0;i < n;i++)
			for (int j = 0;j < m;j++)
			{
				int x, y;
				x = i;
				y = j;
				bool [,]f = new bool[n, m];
				while (true)
				{
					if (f[x, y]) break;
					f[x, y] = true;
					x = (x + 1) % n;
					y = (y + 1) % m;
				}
				
				bool ok = true;
				for (int p = 0;p < n;p++)
					for (int q = 0;q < m;q++)
						if (!f[p, q])
						{
							ok = false;
						}
				if (ok) return "Possible";
			}
			
		return "Impossible";
	}

	// BEGIN KAWIGIEDIT TESTING
	// Generated by KawigiEdit 2.1.4 (beta) modified by pivanof
	#region Testing code generated by KawigiEdit
	[STAThread]
	private static Boolean KawigiEdit_RunTest(int testNum, int p0, int p1, Boolean hasAnswer, string p2) {
		Console.Write("Test " + testNum + ": [" + p0 + "," + p1);
		Console.WriteLine("]");
		FoxAndClassroom obj;
		string answer;
		obj = new FoxAndClassroom();
		DateTime startTime = DateTime.Now;
		answer = obj.ableTo(p0, p1);
		DateTime endTime = DateTime.Now;
		Boolean res;
		res = true;
		Console.WriteLine("Time: " + (endTime - startTime).TotalSeconds + " seconds");
		if (hasAnswer) {
			Console.WriteLine("Desired answer:");
			Console.WriteLine("\t" + "\"" + p2 + "\"");
		}
		Console.WriteLine("Your answer:");
		Console.WriteLine("\t" + "\"" + answer + "\"");
		if (hasAnswer) {
			res = answer == p2;
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
		
		int p0;
		int p1;
		string p2;
		
		// ----- test 0 -----
		p0 = 2;
		p1 = 3;
		p2 = "Possible";
		all_right = KawigiEdit_RunTest(0, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 1 -----
		p0 = 2;
		p1 = 2;
		p2 = "Impossible";
		all_right = KawigiEdit_RunTest(1, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 2 -----
		p0 = 4;
		p1 = 6;
		p2 = "Impossible";
		all_right = KawigiEdit_RunTest(2, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 3 -----
		p0 = 3;
		p1 = 6;
		p2 = "Impossible";
		all_right = KawigiEdit_RunTest(3, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 4 -----
		p0 = 5;
		p1 = 7;
		p2 = "Possible";
		all_right = KawigiEdit_RunTest(4, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 5 -----
		p0 = 10;
		p1 = 10;
		p2 = "Impossible";
		all_right = KawigiEdit_RunTest(5, p0, p1, true, p2) && all_right;
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