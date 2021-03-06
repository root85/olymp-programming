using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;


public class LittleElephantAndString
{
	public int getNumber(string A, string B)
	{
		char[] a = A.ToCharArray();
		char[] b = B.ToCharArray();
		Array.Sort(a);
		Array.Sort(b);
		if (new string(a) != new string(b))
			return -1;
		
		int n = A.Length;
	
		int ok = 0;
		for (int i = n - 1, j = n - 1;i >= 0 && j >= 0;)
		{
			if (A[i] == B[j])
			{
				i--;
				j--;
				ok++;
			}
			else
				i--;
		}
		return n - ok;
	}

	// BEGIN KAWIGIEDIT TESTING
	// Generated by KawigiEdit 2.1.4 (beta) modified by pivanof
	#region Testing code generated by KawigiEdit
	[STAThread]
	private static Boolean KawigiEdit_RunTest(int testNum, string p0, string p1, Boolean hasAnswer, int p2) {
		Console.Write("Test " + testNum + ": [" + "\"" + p0 + "\"" + "," + "\"" + p1 + "\"");
		Console.WriteLine("]");
		LittleElephantAndString obj;
		int answer;
		obj = new LittleElephantAndString();
		DateTime startTime = DateTime.Now;
		answer = obj.getNumber(p0, p1);
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
		
		string p0;
		string p1;
		int p2;
		
		// ----- test 0 -----
		p0 = "ABC";
		p1 = "CBA";
		p2 = 2;
		all_right = KawigiEdit_RunTest(0, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 1 -----
		p0 = "A";
		p1 = "B";
		p2 = -1;
		all_right = KawigiEdit_RunTest(1, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 2 -----
		p0 = "AAABBB";
		p1 = "BBBAAA";
		p2 = 3;
		all_right = KawigiEdit_RunTest(2, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 3 -----
		p0 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		p1 = "ZYXWVUTSRQPONMLKJIHGFEDCBA";
		p2 = 25;
		all_right = KawigiEdit_RunTest(3, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 4 -----
		p0 = "A";
		p1 = "A";
		p2 = 0;
		all_right = KawigiEdit_RunTest(4, p0, p1, true, p2) && all_right;
		// ------------------
		
		// ----- test 5 -----
		p0 = "DCABA";
		p1 = "DACBA";
		p2 = 2;
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
