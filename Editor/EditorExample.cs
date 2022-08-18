using UnityEngine;
using UnityEditor;
using UnityEditor.AnimatedValues;
using System.Collections.Generic;

namespace Deployer.Template.Editor
{
    
    [CustomEditor(typeof(RuntimeExample))]
    public class EditorExample : UnityEditor.Editor
    {
        
        /// <summary>
        /// OnEnable is called on the frame when a script is displayed in the
        /// inspector just before OnInspectorGUI is called the first time.
        /// </summary>
        public void OnEnable()
        {
            
        }

        /// <summary>
        /// OnInspectorGUI is called every frame, if this script is displayed
        /// in the inspector.
        /// </summary>
        public override void OnInspectorGUI()
        {
            
        }
    }
}