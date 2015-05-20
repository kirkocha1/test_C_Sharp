using System;
using System.Collections.Generic;
using System.Text;

namespace first_try
{	
	class MainClass
	{
		//Methods for the first task
		public static String BuildZero (int zero){
			StringBuilder strzero = new StringBuilder ();
			for (int i = 0; i < zero; i++) {
				strzero.Append ("0");
			}
			return strzero.ToString ();
		}

		public static void FindZeroInGuids (int desire, int zeroamount){
			String zero = MainClass.BuildZero (zeroamount);
			int i = 0;
			Console.WriteLine ("Size of Guids:{0}", desire);
			while(i < desire){
				String guid = Guid.NewGuid ().ToString ();
				if (guid.Contains(zero)) {
					Console.WriteLine (guid);
					i++;
				}
			}
		}

		//Methods for the second task
		public static List<String> CommonSubstrings (string str1, string str2)
		{
			if (String.IsNullOrEmpty(str1) || String.IsNullOrEmpty(str2))
				return null;
			List<String> results = new List<String> ();
			List<int[]> num = new List<int[]>();
			String result = "";
			int maxlen = 0;
			int index = 0;
			for (int i = 0; i < str1.Length; i++)
			{
				num.Add (new int [str2.Length]);
				for (int j = 0; j < str2.Length; j++)
				{
					if(str1[i] != str2[j])
						num[i][j] = 0;
					else
					{
						if ((i == 0) || (j == 0)) {
							num [i] [j] = 1;
						} else {
							num [i] [j] = 1 + num [i - 1] [j - 1];
						}
						if (num [i][j] > maxlen) {
							maxlen = num [i][j];
							index = i;
							if (maxlen >= 1){
								while (maxlen > 0) {
									for (int k = maxlen; k > 0; k--) {
										result = result + str1 [index - k + 1];
									}
									results.Add (result);
									result = null;
									maxlen--;
								}
							}
						}
					}
				}
			}
			//delete with "-"
			results.Sort();
			index = 0;
			while (index < results.Count)
			{
				if (results [index].Contains ("-")) {
					results.RemoveAt (index);
				} else {
					index++;
				}
			}
			//delete dublicates
			index = 0;
			while (index < results.Count - 1)
			{
				if (results [index] == results [index + 1]) {
					results.RemoveAt (index);
				} else {
					index++;
				}
			}
			return results;
		}

		public static void MaxCommonSubstringsInGuids (int amount){
			List<String> guids = new List<String>();
			Console.WriteLine ("Guids:");
			for (int i = 0; i < amount; i++) {
				guids.Add (Guid.NewGuid().ToString());
				Console.WriteLine (guids [i]);
			}
			List<String> substrings = new List<String>();
			substrings = MainClass.CommonSubstrings (guids [0], guids [1]);
			String el = "";
			int k = 0;
			substrings.Sort (new StringComparator());
			Console.WriteLine ("Max common strings:");
			for(int i = 0; i < substrings.Count; i++) {
				foreach (String str in guids) {
					if ((str.IndexOf (substrings[i]) != -1)){
						k++;
					}
				}
				if (k == guids.Count) {
					if (substrings [i].Length >= el.Length) {
						el = substrings [i];
						Console.WriteLine (substrings [i]);
					} else {
						break;
					}
				}
				k = 0;
			}
		}

		public static void Main (String[] args)
		{
			try{
				if (args.Length == 1 && args[0] == "?"){
				Console.WriteLine ("this console application can do two tasks if you want to do the 1 one " +
				                  "you should type 3 integer arguments: \n 1 argument is the number of the task" +
								  "\n 2 argument for desired amount of guides with certain zeroes" +
								  "\n 3 argument is amount of zeroes\n" +
				                  "if you want to do the second one you should type 2 integer arguments: \n 1 argument is the number of the task" +
				                  "\n 2 argument for amount of guids");
				}
				else if (args.Length == 3 && System.Convert.ToInt32 (args [0]) == 1) {
					MainClass.FindZeroInGuids (System.Convert.ToInt32 (args [1]), System.Convert.ToInt32 (args [2]));
				}
				else if (args.Length == 2 && System.Convert.ToInt32 (args [0]) == 2){
					MainClass.MaxCommonSubstringsInGuids (System.Convert.ToInt32 (args [1]));
				}
				else{
					Console.WriteLine ("you have typed not enough values or they are wrong, try to restart application with key \"?\" ");
				}
			}
			catch(Exception e){
					Console.WriteLine ("Fatal error", e);
				}
		}
}
}