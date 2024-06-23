using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update

    public MeshRenderer meshRenderer;
    public Color[] colors;
    public int index;
    public float timer;
    public Rigidbody rb;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.color = colors[Random.Range(0, colors.Length)];
    }
 

    private void OnMouseDown()
    {


        //Invoke("PosAndScale", 2.5f);
        InvokeRepeating(nameof(PosAndScale), 2.5f, 1);
        rb.useGravity = false;
       
    }
    public void PosAndScale()
    {
        float rand = Random.Range(-2, 2);
        float scale = Random.Range(5, 10);
        transform.position = new Vector3(rand, rand, rand);
        transform.localScale = new Vector3(scale, scale, scale);

    }
   
}
    
