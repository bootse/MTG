using UnityEngine;
using System.Collections;

public class HandSlot : MonoBehaviour {

	Card currentCard;
	bool haveCard = false;
	public Material emptyMat;
	public Material filledMat;
	public GameCard[] playerSide = new GameCard[5];
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

	void OnMouseDown(){
		for(int i = 0; i < playerSide.Length; i++){
			if(playerSide[i].addCard(currentCard)){
				removeCard();
				break;
			}
		}
	}
}
