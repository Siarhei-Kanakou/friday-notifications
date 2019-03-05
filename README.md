# React Native Notifications for Friday Shop

## Getting started

`$ npm install friday-notifications --save`

### Mostly automatic installation

`$ react-native link friday-notifications`

### Manual installation

#### iOS

Not supported

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.friday.notifications.NotificationsPackage;` to the imports at the top of the file
  - Add `new NotificationsPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
    ```
    include ':friday-notifications'
    project(':friday-notifications').projectDir = new File(rootProject.projectDir, 	'../node_modules/friday-notifications/android')
    ```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
    ```
      compile project(':friday-notifications')
    ```

#### Windows

Not supported

## Usage
```javascript
import FridayNotifications from 'friday-notifications';

// TODO: What to do with the module?
RNFridayNotifications;
```
