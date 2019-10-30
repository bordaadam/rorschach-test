using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Library.Utilities
{
    public static class Utils
    {
        /// <summary>
        /// Sets properties of the calling transform to a given transform.
        /// </summary>
        /// <param name="transform">
        /// The transform that should be copied
        /// </param>
        /// <example>
        /// public Transform myTransform;
        /// (this.)transform.SetProperties(myTransform);
        /// </example>
        /// <remarks>
        /// This is a method extension, so the first parameter should be "ignored".
        /// </remarks>
        public static void SetProperties(this Transform current, Transform transform)
        {
            current.position = transform.position;
            current.rotation = transform.rotation;
            current.localScale = transform.localScale;
        }

        /// <summary>
        /// Gets specific component that is required for this gameobject.
        /// </summary>
        /// <example>
        /// public Light li;
        /// li = gameObject.GetRequiredComponent&lt;Light&gt;();
        /// </example>
        /// <remarks>
        /// It logs if there's a missing component, so checking if a component is null is not required.
        /// </remarks>
        public static T GetRequiredComponent<T>(this GameObject obj) where T : Component
        {
            T component = obj.GetComponent<T>();

            if(component == null)
                Debug.LogWarning("Expected to find component of type " + typeof(T) + " on '" + obj.name + "' but found none.");

            return component;
        }

    }
}
