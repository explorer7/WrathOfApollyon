#if UNITY_EDITOR
using UnityEngine;
using VoxelTerrain;

public class Simple : TextureCallback
{
    /// <summary>
    /// Simple callback for getting the color of a point on the terrain.
    /// </summary>
    /// <returns></returns>
    public override Color GetColor(float plantyNess, float radialDistance, Vector3 normal)
    {
        if (normal.y < .9)
        {
              return Color.gray;
        }

        float normalScale = (normal.y - .9f) * 10;

        float radialScale = 1 - radialDistance * radialDistance * radialDistance * radialDistance * radialDistance;
        plantyNess *= radialScale * normalScale;
        return Color.Lerp(Color.gray, Color.green, plantyNess);
    }
}
#endif