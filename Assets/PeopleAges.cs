using UnityEngine;
using System.Collections;

public class PeopleAges : MonoBehaviour {

	private int [,] peopleAge = new int [1000,1000];
	private int [] years = new int [1000];
	private int bestYear = 0; 
	private int peopleLiving;
	private int mostPeopleLiving = 0;
	private int i = 0;
	private bool checkPeopleAlive = false;

	// Use this for initialization
	void Start () {
		CalculateYears();
	}
	
	void Update () {
		if (!checkPeopleAlive){
			CheckLiving();
		}
	}
	
	void CalculateYears(){
		for(i = 0; i < 101; i++){
			// assign all year values to array
			years[i] = 1900 + i;
			// generate birth year for all people
			peopleAge[i,0] = Random.Range(1900, 2000);
			// generate all death year for all people
			peopleAge[i,i] = Random.Range(peopleAge[i,0], 2000);
			// determine how many alive this year
//			print (peopleAge[i,i]);
			// check is more than previous best year
//			if (bestYear < years[i]){
//			}
			// if is more, then assign top year as this year
			
			// alt. save the year as well as the value of the alive people
			
			// print the year and number alive after we have checked all values
//			Debug.Log("The variable is :" + i);
		}
	}
	
	void CheckLiving(){
		// loop through people and see who many are alive during each year
		for(int y = 0; y < 101; y++){
			for (int p = 0; p < 1000; p++){
				if (peopleAge[p,0] <= years[y] && peopleAge[p,p] >= years[y]){
					peopleLiving ++;
				}
				if (peopleLiving >= mostPeopleLiving){
					mostPeopleLiving = peopleLiving;
					bestYear = years[y];
				}
			}
			peopleLiving = 0;
		}
		Debug.Log("The most people alive were " + mostPeopleLiving + " in the year "  + bestYear);
		checkPeopleAlive = true;
	}
	
}
