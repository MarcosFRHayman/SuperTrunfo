using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Trunfo
{
    public class CardDisplay : MonoBehaviour
    {

        public Card card;

        public TextMeshPro nome;
        public TextMeshPro descricao;
        //public Image artwork;
        public TextMeshPro pontos;
        void Start()
        {
            nome.text = card.Nome;
            descricao.text = card.Descricao;
            pontos.text = card.Pontos.ToString();


        }

    }
}