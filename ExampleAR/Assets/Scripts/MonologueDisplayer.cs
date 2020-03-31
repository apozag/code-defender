using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MonologueDisplayer : MonoBehaviour
{

    Text text;

    string currentParagraph;

    int index;

    bool charLock = true;

    List<string> paragraphs = new List<string>()
    {
        "¡Saludos humano! Mi nombre es Bytey. Soy nada menos que el antivirus de tu móvil. ",
        "Y no cualquier antivirus ¡Uno que habla! ¿Que te parece?",
        "Ya tendremos tiempo de conocernos más a fondo. No te lo tomes a mal, pero hay una emergencia que tengo que resolver cuanto antes con tu ayuda.",
        "Se trata de un virus informático que se ha colado en tu dispositivo y podría ser dañino si no lo eliminamos.",
        "Sé que yo soy el antivirus y es mi trabajo... pero... resulta que mis desarrolladores me han dejado a medio acabar.",
        "Ahí es donde entras tú, me vas a ayudar a hacer mi trabajo programando en el lenguaje de programación Java.",
        "¡No me mires así! ¡No es para tanto! Yo te ayudaré a aprender poco a poco.",
        "Para que puedas ver lo que pasa dentro de tu móvil, encenderé la cámara y proyectaré en REALIDAD AUMENTADA mis alrededores.",
        "No te preocupes, yo tampoco sabía lo que era la realidad aumentada hasta hace poco. Te va a gustar.",
        "¡Vamos a ello!"
    };

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<Text>();

        index = 0;

        showNextPragraph();
    }

    // Update is called once per frame
    void Update()
    {
        if (charLock)
        {
            StartCoroutine(showNextChar());
            charLock = false;
        }
        
    }

    public void showNextPragraph()
    {
        if (paragraphs.Count > 0)
        {
            currentParagraph = paragraphs[0];
            paragraphs.RemoveAt(0);
            index = 0;
            text.text = "";
        }
        else
        {
            goToTopicSelect();
        }
    }

    IEnumerator showNextChar()
    {
        yield return new WaitForSeconds(0.005f);
        for (int i = 0; i < 2; i++)
        {
            if (index < currentParagraph.Length)
            {
                text.text += currentParagraph[index];
                index++;
            }
        }

        charLock = true;

    }

    void goToTopicSelect()
    {
        SceneManager.LoadScene(1);
    }

}
