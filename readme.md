# Omnicept Data Stream

![omnicept2](https://user-images.githubusercontent.com/44561221/169556616-c0327276-e969-4645-a788-f819b250d3fc.jpg)


This Unity project provides a simple scene to capture and view incoming sensor data including:
<ul>
  <li> Heart rate
  <li> Cognitive Load
  <li> Eye Gaze Coordinates
</ul>

Many more data streams can be collected in the future if needed. Please see the <a href="https://developers.hp.com/omnicept/docs/unity">HP Omnicept Docs</a> for further information.


# Getting Started


### Unity Version
We used Unity version 2020.3.22f1. Using this project in other releases is unteseted. You can get this specific version from within <a href="https://unity.com/unity-hub">Unity Hub</a>.


### Configuring the Omnicept SDK
For simplicity's sake, I would simply recommend following <a href="https://www.youtube.com/watch?v=6v6EGLmYWDI">this helpful tutorial</a> supplied by HP to correctly configure the SDK for Unity.

### Running the Application
<ol>
<li>Once the project is loaded inside of Unity and your Omnicept settings are configured, make sure that you are loaded into the Sample Scene. You can find it in Assets/Scenes/Sample Scene.
<li>Everything should be in place at this point. You can go ahead and run the editor.
<li><i>Note: </i>Eye gaze tracking should start on launch, while cognitive load takes about 30 seconds to initialize. Heart rate takes a varying amount of time to start up.
</ol>

<h2>Known issues</h2>

<ol>
<li> Sometimes the app will stop reporting heart rate data. When the program is running, make sure that the green light on the forehead is lit. If it doesn't light up upon launching the editor, detach and reattatch the face gasket.
</ol>

 
<h2>Credits and other helpful links</h2>
<b>Dylan Britain, Spring 2022 Intern @ JSC -</b> <a href="https://www.linkedin.com/in/dylan-britain-962046167/">LinkedIn</a>

<b>Demo -</b> <a href="https://www.youtube.com/watch?v=QN25cM60Bxk">NASA Hybrid Reality Lab YouTube Channel</a> 
