using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helpers
{
    /// <summary>
    /// Destroy all child objects of this transform (Unintentionally evil sounding).
    /// Use it like so:
    /// <code>
    /// transform.DestroyChildren();
    /// </code>
    /// </summary>
    /// 
    public static void DestroyChildren(this Transform t)
    {
        foreach (Transform child in t)
            Object.Destroy(child.gameObject);
    }
}
