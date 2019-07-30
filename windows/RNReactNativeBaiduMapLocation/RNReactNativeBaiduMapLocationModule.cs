using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Baidu.Map.Location.RNReactNativeBaiduMapLocation
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeBaiduMapLocationModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeBaiduMapLocationModule"/>.
        /// </summary>
        internal RNReactNativeBaiduMapLocationModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeBaiduMapLocation";
            }
        }
    }
}
