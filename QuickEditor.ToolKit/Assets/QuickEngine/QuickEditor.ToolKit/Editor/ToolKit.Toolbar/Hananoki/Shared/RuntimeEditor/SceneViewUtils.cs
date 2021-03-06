﻿#if UNITY_EDITOR

using UnityEditor;

namespace HananokiEditor {
	public static class SceneViewUtils {
#if UNITY_2019_1_OR_NEWER
		public static void AddGUI( System.Action<SceneView> func ) {
			SceneView.duringSceneGui += func;
#else
		public static void AddGUI( SceneView.OnSceneFunc func ) {
			SceneView.onSceneGUIDelegate += func;
#endif
		}


#if UNITY_2019_1_OR_NEWER
		public static void RemoveGUI( System.Action<SceneView> func ) {
			SceneView.duringSceneGui -= func;
#else
		public static void RemoveGUI( SceneView.OnSceneFunc func ) {
			SceneView.onSceneGUIDelegate -= func;
#endif
		}

		public static int sceneViewNum => SceneView.sceneViews.Count;


		public static void Repaint() {
			foreach( SceneView p in SceneView.sceneViews ) p.Repaint();
		}
	}
}

#endif
