using System.Collections;
using UnityEngine;
using UnityEngine.UI;
//Script for the text and its properties
//By Germán Guzmán
namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        private Text textHolder;

        //Los headers y serialized fields son para darle formato y que se distinga que cambia que cosa

        //Aqui ponemos el texto y definimos color y fuente
        [Header ("Text Options")]
        [SerializeField] private string input;
        [SerializeField] private Color textColor = Color.white;
        [SerializeField] private Font textFont;

        //Declaramos como queremos los delays para los caracteres
        [Header("Time parameters")]
        [SerializeField] private float delay;
        [SerializeField] private float delayBetweenLines;

        //Establecemos que sonido hace cada caracter
        [Header("Sound")]
        [SerializeField] private AudioClip sound;


        //Ponemos la imagen del personaje que esta hablando
        [Header("Character Image")]
        [SerializeField] private Sprite characterSprite;
        [SerializeField] private Image spriteHolder;

        //Ponemos la imagen del personaje que esta hablando
        [Header("Background Image")]
        [SerializeField] private Sprite background;
        [SerializeField] private Image bgHolder;


        private void Awake()
        {
            textHolder = GetComponent<Text>();
            textHolder.text = "";

            spriteHolder.sprite = characterSprite;
            spriteHolder.preserveAspect = true;

            bgHolder.sprite = background;
            bgHolder.preserveAspect = false;
        }

        //Manda la info a la funcion de WriteText
        private void Start()
        {
            StartCoroutine(WriteText(input, textHolder, textColor, textFont, delay, sound, delayBetweenLines));
        }
    }
}