using UnityEngine;
using System.Collections;

public class GameCard : MonoBehaviour {

	Card currentCard;
	bool haveCard = false;
	public Material emptyMat;
	public Material filledMat;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool addCard(Card card) {
		if(haveCard)
		{
			return false;
		}
		currentCard = card;
		haveCard = true;
		gameObject.renderer.material = filledMat;
		return true;
	}
	
	public void removeCard() {
		currentCard = null;
		haveCard = false;
		gameObject.renderer.material = emptyMat;
	}
}
