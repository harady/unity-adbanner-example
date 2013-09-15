using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour
{
	#region MonoBehaviour Lifecycle Methods
	void Start ()
	{
		AdBannerObserver.Initialize ("a14f12dd9e4d1e0", null, 30.0f);
	}
	#endregion
}
