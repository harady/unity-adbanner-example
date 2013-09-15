
package jp.radiumsoftware.unityplugin.admob;

import java.util.HashMap;

import com.google.ads.*;

import android.app.Activity;
import android.util.Log;
import android.view.Gravity;
import android.widget.RelativeLayout;
import android.widget.RelativeLayout.LayoutParams;

public class AdBannerController {
    static final int bannerViewId = 0x661ad306; // "ggl admob"

    enum AdBannerPosition {
        Top, Bottom;
    }

    private static HashMap<String, Integer> positionMap;
    static {
        positionMap = new HashMap<String, Integer>();
        positionMap.put(AdBannerPosition.Top.name(), Gravity.TOP);
        positionMap.put(AdBannerPosition.Bottom.name(), Gravity.BOTTOM);
    }

    static public void tryCreateBanner(final Activity activity, final String publisher,
            final String testDevice) {
        tryCreateBanner(activity, publisher, testDevice, AdBannerPosition.Bottom.name());
    }

    static public void tryCreateBanner(final Activity activity, final String publisher,
            final String testDevice, final String position) {
        activity.runOnUiThread(new Runnable() {
            public void run() {
                AdView adBanner = (AdView) activity.findViewById(bannerViewId);
                if (adBanner == null) {
                    Log.d("AdMobPlugin", "creates an ad banner.");
                    // Make a layout for ad banner.
                    RelativeLayout layout = new RelativeLayout(activity);
                    activity.addContentView(layout, new LayoutParams(LayoutParams.MATCH_PARENT,
                            LayoutParams.MATCH_PARENT));
                    int gravity = positionMap.get(position);
                    layout.setGravity(gravity);
                    // Make a banner.
                    adBanner = new AdView(activity, AdSize.SMART_BANNER, publisher);
                    adBanner.setId(bannerViewId);
                    layout.addView(adBanner);
                }
                // Request an ad for the banner.
                Log.d("AdMobPlugin", "requests an ad.");
                AdRequest adRequest = new AdRequest();
                if (testDevice != null) adRequest.addTestDevice(testDevice);
                adBanner.loadAd(adRequest);
            }
        });
    }
}
