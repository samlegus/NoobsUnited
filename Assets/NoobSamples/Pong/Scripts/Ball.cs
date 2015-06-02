using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ball : NoobScript
{
	public float speedX;
	public float speedY;

	public GameObject leftRacket;
	public GameObject rightRacket;
	
	public Text playerOneScoreText;
	public Text playerTwoScoreText;

	private int playerOneScore = 0;
	private int playerTwoScore = 0;
		
	//Any code written inside of Start will be called once when the object is created.
	void Start()
	{
		self.SetVelocity (speedX , 0f );
	}
	
	//Any code written instead of Update will be called every time the application updates
	void Update()
	{
		if(self.IsVisibleOnScreen() == false)
		{
			self.SetPosition (0f,0f);
			self.SetVelocity (speedX, 0f);
		}

		playerOneScoreText.text = playerOneScore.ToString ();
		playerTwoScoreText.text = playerTwoScore.ToString ();
	}
	
	//Any code written inside of OnCollisionEnter2D will be called when this 2D object collides with another
	void OnCollisionEnter2D(Collision2D other)
	{
		//Three methods of finding a different game object in our game
		// 1) Make a public game object and drag and drop from the editor
		// 2) gameObject.name
		// 3) Use tags ... gameObject.tag == "tag" / gameObject.CompareTag(tag)

		if(other.gameObject == leftRacket)
		{
			float newVelocityX = 0f;
			float newVelocityY = 0f;
			float racketHeight = other.gameObject.GetColliderHeight();
			
			newVelocityX = speedX;
			newVelocityY = ((self.GetPositionY () - other.gameObject.GetPositionY()) / racketHeight) * speedY;
			
			self.SetVelocity (newVelocityX, newVelocityY);
		}
		if(other.gameObject == rightRacket)
		{
			float newVelocityX = 0f;
			float newVelocityY = 0f;
			float racketHeight = other.gameObject.GetColliderHeight();
			
			newVelocityX = speedX * -1f;
			newVelocityY = ((self.GetPositionY () - other.gameObject.GetPositionY()) / racketHeight) * speedY;
			
			self.SetVelocity (newVelocityX, newVelocityY);
		}

		if(other.gameObject.name == "LeftBoundary")
		{
			playerTwoScore++;
			self.SetPosition (0f,0f);
			self.SetVelocity (speedX, 0f);
		}

		if(other.gameObject.name == "RightBoundary")
		{
			playerOneScore++;
			self.SetPosition (0f,0f);
			self.SetVelocity(-speedX, 0f);
		}
	}
	
	void OnGUI()
	{
		
	}
}