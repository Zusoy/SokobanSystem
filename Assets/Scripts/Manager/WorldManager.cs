using UnityEngine;

namespace Sokoban.Manager
{
    using World;

    public class WorldManager : MonoBehaviour
    {
        [SerializeField]
        private GridElement GridElement = null;
        [SerializeField]
        private Transform GridParent = null;

        [SerializeField]
        private int width;

        [SerializeField]
        private int height;

        private void Start()
        {
            Generator.GenerateWorld(
                this.width,
                this.height,
                this.GridElement,
                this.GridParent
            );
        }
    }
}
