using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour 
	{
		int a = 60;


		void Start ()
		{
			a = MultiplyByTwo (a);
			Debug.Log (a);
		}

		int MultiplyByTwo (int number)
		{
			int ret;
			ret = number * 10;
			return ret;
		}
	}
