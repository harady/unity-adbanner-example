using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour
{
	#region MonoBehaviour Lifecycle Methods
	void Start ()
	{
		AdBannerObserver.Initialize ("ca-app-pub-3167914489550481/5145242950", null, 30.0f);
	}
	#endregion
}
