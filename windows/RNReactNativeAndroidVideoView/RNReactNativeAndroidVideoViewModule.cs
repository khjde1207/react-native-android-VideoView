using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Android.Video.View.RNReactNativeAndroidVideoView
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeAndroidVideoViewModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeAndroidVideoViewModule"/>.
        /// </summary>
        internal RNReactNativeAndroidVideoViewModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeAndroidVideoView";
            }
        }
    }
}
