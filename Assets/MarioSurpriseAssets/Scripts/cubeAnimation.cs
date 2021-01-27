using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cubeAnimation: MonoBehaviour
{
    public Rigidbody coin;
    public GameObject block;
    private Renderer blockRenderer;
    public Material emptyBlock;

    private Vector3 vect;
    private Vector3 coinPosition;
    private Vector3 blockPosition;
    public Vector3 rotation;
    public Vector3 force;

    private int count;


    // Start is called before the first frame update
    void Start()
    {
        vect = new Vector3(0, 0.24f, 0);
        coinPosition = new Vector3(0, 0, 0);
        blockPosition = new Vector3(0, 0, 0);
        rotation = new Vector3(0, 500, 0);
        force = new Vector3(0, 1000, 0);
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        touchBlock();
    }

    void touchBlock()
	{
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.CompareTag("Cube"))
                {
                    if (count < 5)
					{
                        coinPosition.x = block.transform.position.x + vect.x;
                        coinPosition.y = block.transform.position.y + vect.y;
                        coinPosition.z = block.transform.position.z + vect.z;

                        Rigidbody coinInstance;
                        coinInstance = Instantiate(coin, coinPosition, Quaternion.LookRotation(rotation * Time.deltaTime));
                        coinInstance.AddForce(force * Time.deltaTime);

                        count++;
                        if(count != 5)
                            moveBlock();
                    }
                        
                    if (count == 5)
                    {
                        blockRenderer = GetComponent<Renderer>();
                        blockRenderer.material = emptyBlock;
                    }
                }
            }
        }
    }
    
    public int getCount()
	{
        return count;
	}

    void moveBlock()
    {
        blockPosition.x = Random.Range(-1.0f, 1.0f);
        blockPosition.y = Random.Range(-1.0f, 1.0f);
        blockPosition.z = Random.Range(-1.0f, 1.0f);

        block.transform.position = blockPosition;
    }
}