
# react-native-react-native-android-video-view

## Getting started

`$ npm install react-native-react-native-android-video-view --save`

### Mostly automatic installation

`$ react-native link react-native-react-native-android-video-view`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-react-native-android-video-view` and add `RNReactNativeAndroidVideoView.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNReactNativeAndroidVideoView.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.say.lib.videoview.RNReactNativeAndroidVideoViewPackage;` to the imports at the top of the file
  - Add `new RNReactNativeAndroidVideoViewPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-react-native-android-video-view'
  	project(':react-native-react-native-android-video-view').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-react-native-android-video-view/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-react-native-android-video-view')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNReactNativeAndroidVideoView.sln` in `node_modules/react-native-react-native-android-video-view/windows/RNReactNativeAndroidVideoView.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using React.Native.Android.Video.View.RNReactNativeAndroidVideoView;` to the usings at the top of the file
  - Add `new RNReactNativeAndroidVideoViewPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNReactNativeAndroidVideoView from 'react-native-react-native-android-video-view';

// TODO: What to do with the module?
RNReactNativeAndroidVideoView;
```
  