using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Friday.Notifications.RNFridayNotifications
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNFridayNotificationsModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNFridayNotificationsModule"/>.
        /// </summary>
        internal RNFridayNotificationsModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNFridayNotifications";
            }
        }
    }
}
