using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ImageRotator : MonoBehaviour
{
    enum Character
	{
        Mario,
        Link,
        Pikachu
	}

    private int targetID;
    private bool endGame;

    public Material HG0;
    public Material HG1;
    public Material HG2;
    public Material HC0;
    public Material HC1;
    public Material HC2;
    public Material HD0;
    public Material HD1;
    public Material HD2;
    public Material CG0;
    public Material CG1;
    public Material CG2;
    public Material CC0;
    public Material CC1;
    public Material CC2;
    public Material CD0;
    public Material CD1;
    public Material CD2;
    public Material BG0;
    public Material BG1;
    public Material BG2;
    public Material BC0;
    public Material BC1;
    public Material BC2;
    public Material BD0;
    public Material BD1;
    public Material BD2;

    private Renderer myRenderer;
    public Text canvaText;

    private int textureID_HG;
    private int textureID_HC;
    private int textureID_HD;
    private int textureID_CG;
    private int textureID_CC;
    private int textureID_CD;
    private int textureID_BG;
    private int textureID_BC;
    private int textureID_BD;

    // Start is called before the first frame update
    void Start()
    {
        targetID = Random.Range(0, 3);
        textureID_HG = Random.Range(0, 3);
        textureID_HC = Random.Range(0, 3);
        textureID_HD = Random.Range(0, 3);
        textureID_CG = Random.Range(0, 3);
        textureID_CC = Random.Range(0, 3);
        textureID_CD = Random.Range(0, 3);
        textureID_BG = Random.Range(0, 3);
        textureID_BC = Random.Range(0, 3);
        textureID_BD = Random.Range(0, 3);
        myRenderer = gameObject.GetComponent<Renderer>();
        endGame = false;
        ChoiceTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                myRenderer = raycastHit.transform.gameObject.GetComponent<Renderer>();
                if (raycastHit.collider.CompareTag("HG"))
                {
                    textureID_HG++;
                    if (textureID_HG == 3)
                        textureID_HG = (int)Character.Mario;

                    if (textureID_HG == (int)Character.Mario)
                        myRenderer.material = HG0;
                    else if (textureID_HG == (int)Character.Link)
                        myRenderer.material = HG1;
                    else if (textureID_HG == (int)Character.Pikachu)
                        myRenderer.material = HG2;

                    canvaText.text = "";
                }
                else if (raycastHit.collider.CompareTag("HC"))
                {
                    textureID_HC++;
                    if (textureID_HC == 3)
                        textureID_HC = (int)Character.Mario;

                    if (textureID_HC == (int)Character.Mario)
                        myRenderer.material = HC0;
                    else if (textureID_HC == (int)Character.Link)
                        myRenderer.material = HC1;
                    else if (textureID_HC == (int)Character.Pikachu)
                        myRenderer.material = HC2;

                    canvaText.text = "";
                }
                else if(raycastHit.collider.CompareTag("HD"))
                {
                    textureID_HD++;
                    if (textureID_HD == 3)
                        textureID_HD = (int)Character.Mario;

                    if (textureID_HD == (int)Character.Mario)
                        myRenderer.material = HD0;
                    else if (textureID_HD == (int)Character.Link)
                        myRenderer.material = HD1;
                    else if (textureID_HD == (int)Character.Pikachu)
                        myRenderer.material = HD2;

                    canvaText.text = "";
                }
                else if(raycastHit.collider.CompareTag("CG"))
                {
                    textureID_CG++;
                    if (textureID_CG == 3)
                        textureID_CG = (int)Character.Mario;

                    if (textureID_CG == (int)Character.Mario)
                        myRenderer.material = CG0;
                    else if (textureID_CG == (int)Character.Link)
                        myRenderer.material = CG1;
                    else if (textureID_CG == (int)Character.Pikachu)
                        myRenderer.material = CG2;

                    canvaText.text = "";
                }
                else if (raycastHit.collider.CompareTag("CC"))
                {
                    textureID_CC++;
                    if (textureID_CC == 3)
                        textureID_CC = (int)Character.Mario;

                    if (textureID_CC == (int)Character.Mario)
                        myRenderer.material = CC0;
                    else if (textureID_CC == (int)Character.Link)
                        myRenderer.material = CC1;
                    else if (textureID_CC == (int)Character.Pikachu)
                        myRenderer.material = CC2;

                    canvaText.text = "";
                }
                else if (raycastHit.collider.CompareTag("CD"))
                {
                    textureID_CD++;
                    if (textureID_CD == 3)
                        textureID_CD = (int)Character.Mario;

                    if (textureID_CD == (int)Character.Mario)
                        myRenderer.material = CD0;
                    else if (textureID_CD == (int)Character.Link)
                        myRenderer.material = CD1;
                    else if (textureID_CD == (int)Character.Pikachu)
                        myRenderer.material = CD2;

                    canvaText.text = "";
                }
                else if (raycastHit.collider.CompareTag("BG"))
                {
                    textureID_BG++;
                    if (textureID_BG == 3)
                        textureID_BG = (int)Character.Mario;

                    if (textureID_BG == (int)Character.Mario)
                        myRenderer.material = BG0;
                    else if (textureID_BG == (int)Character.Link)
                        myRenderer.material = BG1;
                    else if (textureID_BG == (int)Character.Pikachu)
                        myRenderer.material = BG2;

                    canvaText.text = "";
                }
                else if (raycastHit.collider.CompareTag("BC"))
                {
                    textureID_BC++;
                    if (textureID_BC == 3)
                        textureID_BC = (int)Character.Mario;

                    if (textureID_BC == (int)Character.Mario)
                        myRenderer.material = BC0;
                    else if (textureID_BC == (int)Character.Link)
                        myRenderer.material = BC1;
                    else if (textureID_BC == (int)Character.Pikachu)
                        myRenderer.material = BC2;

                    canvaText.text = "";
                }
                else if (raycastHit.collider.CompareTag("BD"))
                {
                    textureID_BD++;
                    if (textureID_BD == 3)
                        textureID_BD = (int)Character.Mario;

                    if (textureID_BD == (int)Character.Mario)
                        myRenderer.material = BD0;
                    else if (textureID_BD == (int)Character.Link)
                        myRenderer.material = BD1;
                    else if (textureID_BD == (int)Character.Pikachu)
                        myRenderer.material = BD2;

                    canvaText.text = "";
                }
                conditionVictory();
            }
        }
        if (endGame == true)
            newGame();
    }
    
    void ChoiceTarget()
	{
        if(targetID == (int)Character.Mario)
		{
            canvaText.color = Color.red;
            canvaText.text = "Trouvez Mario";
        }
        else if (targetID == (int)Character.Link)
        {
            canvaText.color = Color.green;
            canvaText.text = "Trouvez Link";
        }
        else if (targetID == (int)Character.Pikachu)
        {
            canvaText.color = Color.yellow;
            canvaText.text = "Trouvez Pikachu";
        }
        return;
	}

    void newGame()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Application.LoadLevel(0);
        }
    }

    void conditionVictory()
	{
        if (textureID_HG == (int)Character.Mario && textureID_HC == (int)Character.Mario && textureID_HD == (int)Character.Mario && textureID_CG == (int)Character.Mario && textureID_CC == (int)Character.Mario && textureID_CD == (int)Character.Mario && textureID_BG == (int)Character.Mario && textureID_BC == (int)Character.Mario && textureID_BD == (int)Character.Mario && targetID == (int)Character.Mario)
        {
            canvaText.color = Color.red;
            canvaText.text = "Bravo\n\nRetour au\nmenu principal";
            endGame = true;
        }
        else if (textureID_HG == (int)Character.Link && textureID_HC == (int)Character.Link && textureID_HD == (int)Character.Link && textureID_CG == (int)Character.Link && textureID_CC == (int)Character.Link && textureID_CD == (int)Character.Link && textureID_BG == (int)Character.Link && textureID_BC == (int)Character.Link && textureID_BD == (int)Character.Link && targetID == (int)Character.Link)
        {
            canvaText.color = Color.green;
            canvaText.text = "Bravo\n\nRetour au\nmenu principal";
            endGame = true;
        }

        else if (textureID_HG == (int)Character.Pikachu && textureID_HC == (int)Character.Pikachu && textureID_HD == (int)Character.Pikachu && textureID_CG == (int)Character.Pikachu && textureID_CC == (int)Character.Pikachu && textureID_CD == (int)Character.Pikachu && textureID_BG == (int)Character.Pikachu && textureID_BC == (int)Character.Pikachu && textureID_BD == (int)Character.Pikachu && targetID == (int)Character.Pikachu)
		{
            canvaText.color = Color.yellow;
            canvaText.text = "Bravo\n\nRetour au\nmenu principal";
            endGame = true;
        }
        return;
	}
}
