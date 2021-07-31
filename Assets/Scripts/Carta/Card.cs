using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Trunfo
{
    //@Author Higor
    [CreateAssetMenu(menuName = "ScriptableObjects/Card", fileName = "New Card")]
    public class Card : ScriptableObject
    {
        [SerializeField] public TipoDeTrunfo tipo;
        [SerializeField] private string nome;
        [SerializeField] private string descricao;
        [SerializeField] private int pontos;
        [SerializeField] private Sprite artwork;

        public string Nome { get => nome; }
        public string Descricao { get => descricao; }
        public int Pontos { get => pontos; }

        public void Print()
        {

        }

    }
}