using TMPro;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI text;

    private GridSystem grid;

    private void Start()
    {
        grid = GetComponent<GridSystem>();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out RaycastHit hit))
            {
                Vector3 position = grid.ConvertToGridPoint(hit.transform.position);
                text.text = position.ToString();
                MeshRenderer mesh = hit.transform.GetComponent<MeshRenderer>();
                mesh.material.color = Color.red;
            }
        }
    }
}
