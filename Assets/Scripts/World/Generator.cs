using UnityEngine;

namespace Sokoban.World
{
    /**
     * Handle World Generation with Grids
     */
    public class Generator : MonoBehaviour
    {
        private static Generator instance;

        public static Generator Prepare()
        {
            return Generator.instance;
        }

        private void Awake()
        {
            Generator.instance = this;
        }

        public static void GenerateWorld(int rows, int columns, GridElement gridElement, Transform parent)
        {
            float elementWidth = gridElement.GetComponent<Renderer>().bounds.size.x;
            float elementDepth = gridElement.GetComponent<Renderer>().bounds.size.z;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    Transform gridEl = GameObject.Instantiate(
                        gridElement.gameObject,
                        new Vector3(x * elementWidth, 0, y * elementDepth),
                        Quaternion.identity
                    ).transform;

                    gridEl.SetParent(parent);
                    gridEl.GetComponent<GridElement>().coordinates = new Vector2(x, y);
                }
            }
        }
    }
}
