using UnityEngine;
using UnityEngine.UI;
 
public class Score : MonoBehaviour {
 
	public Text scoreText;
	public int score;
 

   
	// Update is called once per frame
	void Update () {
 
		scoreText.text = "Score: " + score;
 
		if (Input.GetKeyDown("a"))
		{
			score++;
		}
		
		if (Input.GetKeyDown("s"))
		{
			score++;
		}
		
		if(col.gameObject.name == "Finish")
		{
			
			print("You Win !!");
		}
		
	}
}