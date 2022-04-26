using System.Collections;
using UnityEngine;
using UnityEngine.UI;
//Script for the writing animation
//By Germán Guzmán
namespace DialogueSystem
{
    public class DialogueBaseClass : MonoBehaviour
    {
        public bool finished { get; private set; }

        //Aqui esta la magia, se recorre el input y se coloca caracter por caracter en el espacio del texto
        //De igual manera se colocan las propiedades en el objeto
        protected IEnumerator WriteText(string input, Text textHolder, Color textColor, Font textFont, float delay, AudioClip sound, float delayBetweenLines)
        {
            textHolder.color = textColor;
            textHolder.font = textFont;

            for (int i = 0; i < input.Length; i++)
            {
                textHolder.text += input[i];
                SoundManager.instance.PlaySound(sound);
                yield return new WaitForSeconds(delay);
            }

            //Para que se quite el texto despues de darle click
            //yield return new WaitForSeconds(delayBetweenLines);
            yield return new WaitUntil(() => Input.GetMouseButton(0));
            finished = true;
        }
    }
}

