// From Jessie 
// c#
var letterPause = 0.2;
var sound : AudioClip;
 var myText : String = "WELCOME" + "\n" + "TO THE LOFT";
 
function Start () {
    TypeText ();
}
 
function TypeText () {
    for (var letter in myText.ToCharArray()) {
        guiText.text += letter;
        if (sound)
            audio.PlayOneShot (sound);
            yield WaitForSeconds (letterPause);
    }      
}

// From Bernat 
// c#

public float letterPause = 0.2;
public AudioClip sound;
public String myText = "WELCOME" + "\n" + "TO THE LOFT";

public class AutoType : MonoBehaiour
{
    void Start()
    {
        TypeText();
    }

    void public TypeText()
    {
        for( char letter in myText.ToCharArray() )
        {
            Canvas.text += letterl
            if(sound)
            audio.PlayOneShot(sound);
            yield WaitForSeconds (letterPause);
        }
    }
}

//From Bernat

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaiour
{
    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";

    void Start()
    {
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        for(i=0; i<fullText.length; i++)
        {
            currentText = fullText.Substring(0,i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(delay);
        }
    }
}