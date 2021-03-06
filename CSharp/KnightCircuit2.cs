using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;


public class KnightCircuit2
{

	bool [,]vis;
	int w, h;
	public int maxSize(int w, int h)
	{
		if (w > h)
		{
			int t = w;
			w = h;
			h = t;
		}
		this.w = w;
		this.h = h;
		if (w >= 4 && h >= 4)
			return w*h;
			
		if (w == 3 && h >= 4)
			return w*h;
			
		vis = new bool[w, h];
		dfs(0, 0);
		int res = 0;
		for (int i = 0;i < w;i++)
			for (int j = 0;j < h;j++)
				if (vis[i, j]) res++;
		return res;
	}	
	
	void dfs(int x, int y)
	{
		if (x < 0 || x >= w || y < 0 || y >= h) return;
		if (vis[x, y])
			return;
		vis[x, y] = true;
		
		dfs(x+2,y+1); dfs(x+2,y-1); dfs(x-2,y+1); dfs(x-2,y-1); dfs(x+1,y+2); dfs(x+1,y-2); dfs(x-1,y+2); dfs(x-1,y-2);
	}

	// BEGIN KAWIGIEDIT TESTING
	// Generated by KawigiEdit 2.1.4 (beta) modified by pivanof
	#region Testing code generated by KawigiEdit
	[STAThread]
	private static Boolean KawigiEdit_RunTest(int testNum, int p0, int p1, Boolean hasAnswer, int p2) {
		Console.Write("Test " + testNum + ": [" + p0 + "," + p1);
		Console.WriteLine("]");
		KnightCircuit2 obj;
		int answer;
		obj = new KnightCircuit2();
		DateTime startTime = DateTime.Now;
		answer = obj.maxSize(p0, p1);
		DateTime endTime = DateTime.Now;
		Boolean res;
		res = true;
		Console.WriteLine("Time: " + (endTime - startTime).TotalSeconds + " seconds");
		if (hasAnswer) {
			Console.WriteLine("Desired answer:");
			Console.WriteLine("\t" + p2);
		}
		Console.WriteLine("Your answer:");
		Console.WriteLine("\t" + answer);
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
		int p2;
		
		// ----- test 0 -----
		p0 = 1;
		p1 = 1;
		p2 = 1;
		all_right = KawigiEdit_RunTest(0, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 1 -----
		p0 = 15;
		p1 = 2;
		p2 = 8;
		all_right = KawigiEdit_RunTest(1, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 2 -----
		p0 = 100;
		p1 = 100;
		p2 = 10000;
		all_right = KawigiEdit_RunTest(2, p0, p1, true, p2) && all_right;
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
