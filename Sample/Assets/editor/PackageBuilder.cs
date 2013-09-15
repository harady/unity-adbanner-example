using UnityEngine;
using UnityEditor;
using System;
using System.Collections;

/// <summary>
/// Unityパッケージ作成スクリプト.
/// </summary>
public static class PackageBuilder
{
	private static string GetPackageName (DateTime buildDateTime)
	{
		return ("unity-adbanner-plugin-" + buildDateTime.ToString ("yyyyMMddHHmm") + ".unitypackage");
	}
	
	[MenuItem("Build/BuildUnityPackage")]
	public static void BuildUnityPackage ()
	{
		DateTime buildDateTime = DateTime.Now;
		AssetDatabase.ExportPackage ("Assets/Plugins", GetPackageName (buildDateTime), 
			ExportPackageOptions.IncludeLibraryAssets 
			| ExportPackageOptions.IncludeDependencies 
			| ExportPackageOptions.Interactive);
	}
}
