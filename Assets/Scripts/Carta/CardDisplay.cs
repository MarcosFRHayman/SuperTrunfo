using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CardDisplay : MonoBehaviour {

	public Card card;

	public TextMeshPro nome;
	public TextMeshPro descricao;
	//public Image artwork;
	public TextMeshPro pontos;
	void Start () {
		nome.text = card.nome;
		descricao.text = card.descricao;
		pontos.text = card.pontos.ToString();
		
		
	}
	
}
