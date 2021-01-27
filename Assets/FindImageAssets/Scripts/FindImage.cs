using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindImage : MonoBehaviour
{
   /* public ImageRotator HG;
    public ImageRotator HC;
    public ImageRotator HD;
    public ImageRotator CG;
    public ImageRotator CC;
    public ImageRotator CD;
    public ImageRotator BG;
    public ImageRotator BC;
    public ImageRotator BD;
    public Text canvas;

    private int targetID;

    // Start is called before the first frame update
    void Start()
    {
        HG = new ImageRotator();
        HC = new ImageRotator();
        HD = new ImageRotator();
        CG = new ImageRotator();
        CC = new ImageRotator();
        CD = new ImageRotator();
        BG = new ImageRotator();
        BC = new ImageRotator();
        BD = new ImageRotator();
        targetID = Random.Range(0, 3);//ne change pas ou reviens toujour a 0?
        InitText();
    }

    void InitText()
	{
        if (targetID == 0)
        {
            canvas.color = Color.red;
            canvas.text = "Trouvez Mario";
        }
        else if (targetID == 1)
        {
            canvas.color = Color.green;
            canvas.text = "Trouvez Link";
        }
        else if (targetID == 2)
        {
            canvas.color = Color.yellow;
            canvas.text = "Trouvez Pikachu";
        }
    }

    // Update is called once per frame
    void Update()
    {
		if (HG.GetFlag() == true || HC.GetFlag() == true || HD.GetFlag() == true || CG.GetFlag() == true || CC.GetFlag() == true || CD.GetFlag() == true || BG.GetFlag() == true || BC.GetFlag() == true || BD.GetFlag() == true)
		{
            canvas.text = "";
		}
        if (targetID == HG.GetTextureID() && targetID == HC.GetTextureID() && targetID == HD.GetTextureID() && targetID == CG.GetTextureID() && targetID == CC.GetTextureID() && targetID == CD.GetTextureID() && targetID == BG.GetTextureID() && targetID == BC.GetTextureID() && targetID == BD.GetTextureID())
		{
            PutFlagsToZero();
            canvas.text = "Felicitation!!!\n\nPour recommencer\nappuyez sur l'écran";
            NewGame();
        }
    }

    void NewGame()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Application.LoadLevel(0);
        }
    }

    void PutFlagsToZero()
	{
        HG.SetFlag(false);
        HC.SetFlag(false);
        HD.SetFlag(false);
        CG.SetFlag(false);
        CC.SetFlag(false);
        CD.SetFlag(false);
        BG.SetFlag(false);
        BC.SetFlag(false);
        BD.SetFlag(false);
    }*/
}
