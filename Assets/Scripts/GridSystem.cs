using UnityEngine;

public class GridSystem : MonoBehaviour
{
    [SerializeField] GameObject origin;

    public Vector3 ConvertToGridPoint(Vector3 position)
    {
        Vector3 distance = position - origin.transform.position;
        float x = distance.x + distance.z;
        float z = 0.5f * distance.x - 0.5f * distance.z;
        return new Vector3(x, 0, z);
    }

    public Vector3 ConvertToWorldPoint(Vector3 position)
    {
        Vector3 distance = position - origin.transform.position;
        float x = 0.5f * distance.x - distance.z;
        float z = 0.5f * distance.x + distance.z;
        return new Vector3(x, 0, z);
    }
}
