using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Trunfo
{
    public class CardDisplay : MonoBehaviour
    {

        [SerializeField] private Card card;

        [SerializeField] private TextMeshPro nome;
        [SerializeField] private TextMeshPro descricao;
        //public Image artwork;
        [SerializeField] private TextMeshPro pontos;
        void Start()
        {
            nome.text = card.Nome;
            descricao.text = card.Descricao;
            pontos.text = card.Pontos.ToString();


        }

    }
}