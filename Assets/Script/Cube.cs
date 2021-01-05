
using UnityEngine;

public class Cube : MonoBehaviour {
    private void Start()
    {
        GenerateColor();
    }
    public void GenerateColor() {
    GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();
    }
    public void Reset()
    {
    gameObject.GetComponent<Renderer>().sharedMaterial.color = Color.white;
    }
}
