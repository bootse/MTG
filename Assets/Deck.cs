using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {

	public List<Card> CardDeck = new List<Card>();
	public Card[] CardsForDeck = new Card[25];
	public Card CardObject;
	public HandSlot[] playerHand = new HandSlot[7];
	// Use this for initialization
	void Start () {
		List<int> randomized = new List<int>();
		for(int i = 0; i < CardsForDeck.Length; i++)
		{
			CardsForDeck[i] = (Instantiate(CardObject.gameObject) as GameObject).GetComponent<Card>();
			CardsForDeck[i].Value = i+1;
			randomized.Add(i);
		}
		while(randomized.Count > 0)
		{
			int a = Random.Range(0,randomized.Count);
			CardDeck.Add(CardsForDeck[randomized[a]]);
			randomized.RemoveAt(a);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		for(int i = 0; i < playerHand.Length; i++){
			if(playerHand[i].addCard(CardDeck[0])){
				CardDeck.RemoveAt(0);
				break;
			}
		}
	}
}
