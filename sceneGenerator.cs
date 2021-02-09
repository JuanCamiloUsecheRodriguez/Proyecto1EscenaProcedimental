using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneGenerator : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //TERRAINA
        GameObject terrainA = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer terrainA_R = terrainA.GetComponent<Renderer>();
        terrainA.transform.position = new Vector3(-3.67f, -5f, 0);
        terrainA.transform.localScale = new Vector3(40f, 14f, 4f);
        terrainA_R.material.color = new Color(0.58f,0.29f,0.04f,0.85f);

        //TERRAINB
        GameObject terrainB = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Renderer terrainB_R = terrainB.GetComponent<Renderer>();
        terrainB.transform.position = new Vector3(42.6f, -5f, 0);
        terrainB.transform.localScale = new Vector3(40f, 14f, 4f);
        terrainB_R.material.color = new Color(0.58f, 0.29f, 0.04f, 0.85f);

        //BRICKS1TO3
        float j = -5.71f;
        for (int i = 0; i < 3; i++)
        {
            GameObject brick = GameObject.CreatePrimitive(PrimitiveType.Cube);
            brick.transform.position = new Vector3(j, 7.5f, 0f);
            brick.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            brick.GetComponent<Renderer>().material.color = new Color(0.58f, 0.29f, 0.04f, 0.85f);
            j += 1.66f;
        }
        //BRICKS4TO5
        j = -5.71f;
        for (int i = 0; i < 2; i++)
        {
            GameObject brick = GameObject.CreatePrimitive(PrimitiveType.Cube);
            brick.transform.position = new Vector3(j, 11.2f, 0f);
            brick.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            brick.GetComponent<Renderer>().material.color = new Color(0.58f, 0.29f, 0.04f, 0.85f);
            j += 3.22f;
        }
        //BRICK6
        GameObject brick6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        brick6.transform.position = new Vector3(12.55f, 7.5f, 0f);
        brick6.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        brick6.GetComponent<Renderer>().material.color = new Color(0.58f, 0.29f, 0.04f, 0.85f);

        //CLOUD1
        GameObject cloud1 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        cloud1.transform.position = new Vector3(-7.54f, 19.5f, 17.21f);
        cloud1.transform.localScale = new Vector3(3.91f, 5.33f, 1f);
        cloud1.transform.rotation *= Quaternion.Euler(0, 0, 90f);
        cloud1.GetComponent<Renderer>().material.color = Color.white;

        //CLOUD2
        GameObject cloud2 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        cloud2.transform.position = new Vector3(41.96f, 15.5f, 17.21f);
        cloud2.transform.localScale = new Vector3(5.26f, 11.71f, 1f);
        cloud2.transform.rotation *= Quaternion.Euler(0, 0, 90f);
        cloud2.GetComponent<Renderer>().material.color = Color.white;

        //BACKGROUND
        GameObject background = GameObject.CreatePrimitive(PrimitiveType.Plane);
        background.transform.position = new Vector3(413.7f, 10.3f, 194.1f);
        background.transform.localScale = new Vector3(100f, 1f, 60f);
        background.transform.rotation *= Quaternion.Euler(-90f, 0, 0);
        background.GetComponent<Renderer>().material.color = new Color(0.38f, 0.52f, 0.97f, 0.85f); 
        
        //MUSHROOMS
        CreateMushroom(-4.069f,9.22f,0f);
        CreateMushroom(12.5f, 9.22f, 0f);

        //COINS
        CreateCoin(-5.6f, 13.3f, 0f);
        CreateCoin(-2.44f, 13.3f, 0f);
        CreateCoin(26.22f, 8.32f, 0f);
        CreateCoin(30.64f, 8.32f, 0f);
        CreateCoin(28.31f, 12.26f, 0f);

        //GOOMBAS
        CreateGoomba(-3.84f, 3.567f, 0f);
        CreateGoomba(0f, 3.567f, 0f);
        CreateGoomba(27.25f, 3.567f, 0f);

        //PIPES
        CreatePipe(6.16f,3.6f,0f);
        CreatePipe(38.75f, 3.6f, 0f);

        //PLANTS
        CreatePlant(6.22f, 7.3f, 0f);
        CreatePlant(38.72f, 7.3f, 0f);
    }
	

    public void CreateMushroom(float i, float j, float k)
    {
        GameObject head = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject mushroom = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject spot1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject spot2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject spot3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject eye1 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject eye2 = GameObject.CreatePrimitive(PrimitiveType.Capsule);

        head.transform.parent = mushroom.transform;
        spot1.transform.parent = mushroom.transform;
        spot2.transform.parent = mushroom.transform;
        spot3.transform.parent = mushroom.transform;
        eye1.transform.parent = mushroom.transform;
        eye2.transform.parent = mushroom.transform;

        head.transform.localPosition = new Vector3(0f, -0.401f, 0f);
        head.transform.localScale = new Vector3(0.65f, 0.3f, 0.6f);
        head.GetComponent<Renderer>().material.color = new Color(0.32f, 0.31f, 0.3f, 0.3f);

        spot1.transform.localPosition = new Vector3(0.011f, 0.211f, -0.193f);
        spot1.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        spot1.GetComponent<Renderer>().material.color = Color.white;

        spot2.transform.localPosition = new Vector3(0.178f, 0.013f, -0.218f);
        spot2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        spot2.GetComponent<Renderer>().material.color = Color.white;

        spot3.transform.localPosition = new Vector3(-0.177f, 0f, -0.226f);
        spot3.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        spot3.GetComponent<Renderer>().material.color = Color.white;

        eye1.transform.localPosition = new Vector3(-0.106f, -0.485f, -0.279f);
        eye1.transform.localScale = new Vector3(0.06f, 0.06f, 0.06f);
        eye1.GetComponent<Renderer>().material.color = Color.black;

        eye2.transform.localPosition = new Vector3(0.102f, -0.485f, -0.279f);
        eye2.transform.localScale = new Vector3(0.06f, 0.06f, 0.06f);
        eye2.GetComponent<Renderer>().material.color = Color.black;

        mushroom.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
        mushroom.transform.position = new Vector3(i, j, k);
        mushroom.GetComponent<Renderer>().material.color = new Color(0.92f, 0.1f, 0.14f, 0.85f);

    }

    public void CreateCoin(float i, float j, float k)
    {
        GameObject detail = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject coin = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

        detail.transform.parent = coin.transform;

        detail.transform.localPosition = new Vector3(0f, -1.74f, 0f);
        detail.transform.localScale = new Vector3(0.17f, 1f, 0.47f);
        detail.GetComponent<Renderer>().material.color = Color.yellow;

        coin.transform.localScale = new Vector3(0.7f, 0.1f, 1f);
        coin.transform.rotation *= Quaternion.Euler(90f, 0, 0);
        coin.transform.position = new Vector3(i, j, k);
        coin.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void CreateGoomba(float i, float j, float k)
    {
        GameObject head = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject body = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject leg1 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject leg2 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject eyebrow1 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject eyebrow2 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject eye1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject eye2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        body.transform.parent = head.transform;
        leg1.transform.parent = head.transform;
        leg2.transform.parent = head.transform;
        eyebrow1.transform.parent = head.transform;
        eyebrow2.transform.parent = head.transform;
        eye1.transform.parent = head.transform;
        eye2.transform.parent = head.transform;

        //body
        body.transform.localPosition = new Vector3(0f, -1.097f, 0f);
        body.transform.localScale = new Vector3(1f, 1.68f, 1f);
        body.GetComponent<Renderer>().material.color = new Color(0.32f, 0.31f, 0.3f, 0.3f);

        //leg1
        leg1.transform.localPosition = new Vector3(-0.462f, -1.336f, 0f);
        leg1.transform.localScale = new Vector3(0.61f, 0.61f, 0.61f);
        leg1.GetComponent<Renderer>().material.color = Color.black;

        //leg2
        leg2.transform.localPosition = new Vector3(0.54f, -1.336f, 0f);
        leg2.transform.localScale = new Vector3(0.61f, 0.61f, 0.61f);
        leg2.GetComponent<Renderer>().material.color = Color.black;

        //eyebrow1
        eyebrow1.transform.localPosition = new Vector3(-0.322f, 0.58f, -0.472f);
        eyebrow1.transform.localScale = new Vector3(0.1f, 0.3f, 0.1f);
        eyebrow1.transform.rotation *= Quaternion.Euler(0, 0, 31.61f);
        eyebrow1.GetComponent<Renderer>().material.color = Color.black;

        //eyebrow2
        eyebrow2.transform.localPosition = new Vector3(0.365f, 0.597f, -0.472f);
        eyebrow2.transform.localScale = new Vector3(0.1f, 0.3f, 0.1f);
        eyebrow2.transform.rotation *= Quaternion.Euler(0, 0, -31.61f);
        eyebrow2.GetComponent<Renderer>().material.color = Color.black;

        //eye1
        eye1.transform.localPosition = new Vector3(-0.198f, 0.08f, -0.487f);
        eye1.transform.localScale = new Vector3(0.1f, 0.2f, 0.1f);
        eye1.GetComponent<Renderer>().material.color = Color.black;

        //eye2
        eye2.transform.localPosition = new Vector3(0.218f, 0.08f, -0.487f);
        eye2.transform.localScale = new Vector3(0.1f, 0.2f, 0.1f);
        eye2.GetComponent<Renderer>().material.color = Color.black;

        //head
        head.transform.position = new Vector3(i, j, k);
        head.transform.localScale = new Vector3(1.52f, 0.84f, 1.45f);
        head.GetComponent<Renderer>().material.color = new Color(0.29f, 0.12f, 0.06f, 1f);

    }

    public void CreatePipe(float i, float j, float k)
    {
        GameObject top = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject body = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject hole = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

        top.transform.parent = body.transform;
        hole.transform.parent = body.transform;

        top.transform.localPosition = new Vector3(0f, 1.41f, 0f);
        top.transform.localScale = new Vector3(1.2f, 0.4f, 1.2f);
        top.GetComponent<Renderer>().material.color = new Color(0.26f, 0.69f, 0.27f, 0.3f);

        hole.transform.localPosition = new Vector3(0f, 1.014f, 0f);
        hole.transform.localScale = new Vector3(0.799f, 0.799f, 0.799f);
        hole.GetComponent<Renderer>().material.color = Color.black;

        body.transform.localScale = new Vector3(3f, 1.5f, 3f);
        body.transform.position = new Vector3(i, j, k);
        body.GetComponent<Renderer>().material.color = new Color(0.26f, 0.69f, 0.27f, 0.3f);
    }

    public void CreatePlant(float i, float j, float k)
    {
        GameObject head = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        GameObject stem = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject lip1 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject lip2 = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        GameObject leaf = GameObject.CreatePrimitive(PrimitiveType.Capsule);

        head.transform.parent = stem.transform;
        lip1.transform.parent = stem.transform;
        lip2.transform.parent = stem.transform;
        leaf.transform.parent = stem.transform;

        head.transform.localPosition = new Vector3(0f, 1.77f, 0f);
        head.transform.localScale = new Vector3(2.93f, 1.7f, 2.93f);
        head.GetComponent<Renderer>().material.color = new Color(0.92f, 0.1f, 0.14f, 0.85f);

        lip1.transform.localPosition = new Vector3(-0.82f, 2.949f, 0f);
        lip1.transform.localScale = new Vector3(0.51f, 1f, 1f);
        lip1.transform.rotation *= Quaternion.Euler(0, 0, 58.61f);
        lip1.GetComponent<Renderer>().material.color = Color.white;

        lip2.transform.localPosition = new Vector3(0.77f, 2.907f, 0f);
        lip2.transform.localScale = new Vector3(0.531f, 1.05f, 0.99f);
        lip2.transform.rotation *= Quaternion.Euler(0, 0, -58.61f);
        lip2.GetComponent<Renderer>().material.color = Color.white;

        leaf.transform.localPosition = new Vector3(-1.11f, 0, 0f);
        leaf.transform.localScale = new Vector3(0.56f, 1.21f, 0.1f);
        leaf.transform.rotation *= Quaternion.Euler(0, 0, 90f);
        leaf.GetComponent<Renderer>().material.color = Color.green;

        stem.transform.localScale = new Vector3(0.6f, 1f, 0.6f);
        stem.transform.position = new Vector3(i, j, k);
        stem.GetComponent<Renderer>().material.color = Color.green;
    }



    // Update is called once per frame
    void Update () {
		
	}
}
