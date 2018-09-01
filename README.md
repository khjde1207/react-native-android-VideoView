
# react-native-android-video-view

## Getting started

`$ npm install react-native-android-video-view --save`

### Mostly automatic installation

`$ react-native link react-native-android-video-view`

### Manual installation


#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.say.lib.videoview.RNReactNativeAndroidVideoViewPackage;` to the imports at the top of the file
  - Add `new RNReactNativeAndroidVideoViewPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-android-video-view'
  	project(':react-native-android-video-view').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-android-video-view/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-android-video-view')
  	```


## Usage
```javascript
import RNReactNativeAndroidVideoView from 'react-native-android-video-view';

// TODO: What to do with the module?
RNReactNativeAndroidVideoView;
```
