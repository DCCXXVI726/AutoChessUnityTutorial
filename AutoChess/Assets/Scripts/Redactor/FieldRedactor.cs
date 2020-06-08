using UnityEngine;
using UnityEditor;

public class FieldRedactor
{
    public static Transform tilePrefab = Resources.Load<GameObject>("Prefabs/Tile").transform;
    public static int length = 60;
    public static int width = 20;

    [MenuItem("Redactor/Create Field")]
    public static void CreateField() 
    {
        GameObject field = new GameObject();
        field.name = "Field";
        for (int x = 0; x < length; x++)
        {
            for (int z = 0; z < width; z++)
            {
                Transform tile = (Transform)Object.Instantiate(tilePrefab, new Vector3(x, 0, z), Quaternion.identity);
                tile.name = "Tile" + x + "_" + z;
                tile.parent = field.transform;
            }
        }
    }
}
