using UnityEngine;
using System.Collections;

public class BinScript : MonoBehaviour {

	//when collider stays in the bin trigger
	void OnTriggerStay2D(Collider2D coll)
	{
		//if the collider gameobject name is item
		if (coll.gameObject.tag == "Item") 
		{
			//finds the items type and checks if it is in the correct bin
			string thisItemType = coll.gameObject.GetComponent<FoodScript>().itemType;
			if (thisItemType == "Glass" || thisItemType == "Plastic" || thisItemType == "Paper") 
			{
				if (this.gameObject.name == "Blue")
				{
				//destroys the object and adds score
				Destroy(coll.gameObject);
				//add score
				}
				else
				{
					//if fails then the end screen is played 
					Application.LoadLevel("End Scene");
					
				}
			}
			else if (thisItemType == "Food" )
			{
				if(this.gameObject.name == "Green")
				{
				Destroy(coll.gameObject);
				//add score
				}
				else
				{
					//if fails then the end screen is played 
					Application.LoadLevel("End Scene");
					
				}
			}
			else if (thisItemType == "Misc" )
			{
				if(this.gameObject.name == "Trash")
				{
				Destroy(coll.gameObject);
				//add score
				}
				else
				{
					//if fails then the end screen is played 
					Application.LoadLevel("End Scene");
					
				}
			}



		}
	}
}
