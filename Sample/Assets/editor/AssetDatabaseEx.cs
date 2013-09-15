using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Asset database ex.
/// </summary>
public static class AssetDatabaseEx
{
	/// <summary>
	/// 指定したディレクトリ内に含まれるAssetのパス一覧を取得する.
	/// </summary>
	/// <returns>
	/// 指定したディレクトリ内に含まれるAssetのパス一覧.
	/// </returns>
	/// <param name='dirPath'>
	/// Assetのパス一覧を取得したいディレクトリのパス.
	/// </param>
	public static string[] GetAllAssetPathsAtDir (string dirPath)
	{
		List<string> result = new List<string> ();
		foreach (string aPath in AssetDatabase.GetAllAssetPaths()) {
			if (aPath.Contains (dirPath)) {
				result.Add (aPath);
			}
		}
		return result.ToArray ();
	}
}
