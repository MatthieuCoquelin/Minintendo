using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class marioSurprise : MonoBehaviour
{
    public Text canvas;
    public Text numberCoin;
    public cubeAnimation m_cubeAnimation;

    // Start is called before the first frame update
    void Start()
    {
        canvas.text = "";
        numberCoin.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (m_cubeAnimation.getCount() >= 1)
        {
            numberCoin.text = "Nombre de blocs\ntrouvés: " + m_cubeAnimation.getCount().ToString();
        }

        if (m_cubeAnimation.getCount() < 1)
        {
            canvas.text = "Trouvez tous\nles cubes";
        }
        else if (m_cubeAnimation.getCount() == 1)
		{
            canvas.text = "";
        }
        else if (m_cubeAnimation.getCount() == 5)
		{
            canvas.text = "Bravo\n\nTouchez l'écran\npour revenir au\nmenu principal";
            newGame();
        }
    }

    void newGame()
	{
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
            Application.LoadLevel(0);
        }
    }
}
