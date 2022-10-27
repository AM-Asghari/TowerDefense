using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HoverScript : MonoBehaviour
{
    public Color hoverColor;
    private Renderer rend;
    private Color startColor;

    private List<Material> myMaterials;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        List<Material> myMaterials = GetComponent<Renderer>().materials.ToList();
        rend.material = myMaterials[1];
        startColor = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
