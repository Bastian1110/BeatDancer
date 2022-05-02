using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sign : MonoBehaviour
{
    public TextMeshProUGUI C_texto;
    public int frase = 1;
    public GameObject infoPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            infoPanel.SetActive(true);
            if (frase == 1)
            {
                C_texto.text = "Sometimes when playing the Snare drum the stick is allowed to bounce back and hit the head again, this a unique technique known as mammy-daddy beats. ";
            }
            if (frase == 2)
            {
                C_texto.text = "The Snare drum can be played with different sticks like wire brushes (usted in jazz) , small mallets (those usted for the timpani) and marimba beaters(produce a darker sound) .";
            }
            if (frase == 3)
            {
                C_texto.text = "Snare drums are placed on a stand which allows the musician to adjust the height and angle of the instrument. ";
            }

            
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        infoPanel.SetActive(false);
    }
}
