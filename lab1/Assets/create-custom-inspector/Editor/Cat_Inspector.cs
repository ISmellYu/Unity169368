using UnityEditor;
using UnityEngine.UIElements;

namespace create_custom_inspector.Editor
{
    [CustomEditor(typeof(Cat))]
    public class Cat_Inspector : UnityEditor.Editor
    {
        public override VisualElement CreateInspectorGUI()
        {
            // Create a new VisualElement to be the root of our Inspector UI.
            VisualElement myInspector = new VisualElement();

            // Add a simple label.
            myInspector.Add(new Label("haaalo"));

            // Return the finished Inspector UI.
            return myInspector;
        }
    }
}