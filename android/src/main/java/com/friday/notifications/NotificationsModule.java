package com.friday.notifications;

import com.facebook.react.bridge.ReactApplicationContext;
import com.facebook.react.bridge.ReactContextBaseJavaModule;
import com.facebook.react.bridge.ReactMethod;
import com.facebook.react.bridge.Callback;

public class NotificationsModule extends ReactContextBaseJavaModule {

  private final ReactApplicationContext reactContext;

  public NotificationsModule(ReactApplicationContext reactContext) {
    super(reactContext);
    this.reactContext = reactContext;
  }

  @Override
  public String getName() {
    return "Notifications";
  }
}
