using System;
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
        [SerializeReference] private float[] pontos;
        [SerializeField] private Sprite artwork;

        public string Nome { get => nome; }
        public string Descricao { get => descricao; }
        ///A referencia não é alterável
        public float[] Pontos { get => (float[])pontos.Clone(); }

        void OnValidate()
        {
            try
            {
                if (pontos.Length != tipo.Atributos.Length)
                {
                    Debug.LogWarning("Não se deve ter um número diferente de atributos e pontos.\n"
                    + "Warning para a carta: "
                    + name);
                }
            }
            catch (NullReferenceException) { }
        }
        internal void Initialize()
        {
            pontos = new float[tipo.Atributos.Length];
        }

    }
}