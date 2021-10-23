# FoodMenu

A 2D animation that shows a menu with numerous food items that may be chosen from a dropdown menu and displayed to the user. The project is built on Unity version 2019.4.16f1.

## Getting Started

**Read the [CONTRIBUTION.md](./CONTRIBUTION.md) before contributing.**

1. Star and Fork the repository.
2. Clone the repository using the following command in Git:
   ```
   git clone https://github.com/pranshi112/FoodMenu.git
   ```
3. Navigate inside the cloned project using
   ```
   cd FoodMenu
   ```
4. You are now on the *main* branch. To start making changes, switch to a new branch using 
   ```
   git checkout -b <BRANCH-NAME>
   ```
5. Install Unity LTS Release 2019.4.16f1 from the link [here](https://unity3d.com/unity/qa/lts-releases?version=2019.4&page=2).
6. Open the project folder in the Unity Editor.
7. Navigate to `Scenes` folder and open `SampleScene`. Do all of your work in __16:9 aspect ratio__ of the Game View.
8. You're all set! Go on making changes.

## Make a Pull Request

1. Commit your changes in the local project using the following commands in Git:
    ```
    git add .
    git commit -m <message>
    ```
2. Push these changes to your forked repository using 
   ```
   git push origin <CURRENT-BRANCH-NAME>
   ```
3. Go to your forked repository, reload, and click on the **Compare & pull request** button.
4. Create the pull request with a detailed description of your changes.

## Run the Builds

**For Windows build**

1. Navigate to `Build\WinBuild` folder and open `Foodmenu.exe`.

**For WebGL build**

The __correct__ way to run Unity-WebGL build locally is to use a simple server.

__ALTERNATIVE 1: Servez__

1. Install Servez, a simple web server for local web development, from the link [here](https://greggman.github.io/servez/).
2. Run Servez and locate `Build\WebGL` in __Folder to Serve__.
3. Click __Start__ and then __Launch Browser__. Now the WebGL build will run.
4. To stop server, Click __Stop__ in Servez.

__ALTERNATIVE 2: XAMPP__

1. Install XAMPP, a open source Apache server distribution, from the link [here](https://www.apachefriends.org/download.html).
2. Run XAMPP and click __Config__ on __Apache__ module row and then click `Apache (httpd.conf)`.
3. Replace __DocumentRoot "C:/xamppm/apache"__ and __<Directory "C:/xamppm/apache">__ with `Build\WebGL`'s absolute path.
4. Save and close it. Then start Apache server and click __Admin__.
5. To stop server, Click __Stop__ in XAMPP Control Panel.

__ALTERNATIVE 3: Live Server__

1. Install Visual Studio Code from the link [here](https://code.visualstudio.com/).
2. Run Visual Studio Code, Go to `File -> Open Folder`, locate `Build\WebGL`.
3. Go to __Extensions__ from left toolbar and install __Live Server__ extension.
4. Then, right click on `index.html` from Visual Studio Code and click __Open with Live Server__. 

__ALTERNATIVE 4: SimpleHTTPServer__

1. Install __latest__ python version from the link [here](https://www.python.org/).
2. While installing, make sure to check the __"Add Python 3.x to PATH"__ checkbox.
3. Open your terminal and go to `Build\WebGL` or first go to `Build\WebGL` and type __"cmd"__ in address bar and enter.
4. Type the following command.
   ```
   # For python 3
   python -m http.server <portNum>
   # For python 2
   python -m SimpleHTTPServer <portNum>
   ```
   If your didn't put any `portNum` by default, this will run on port 8000.
5. Then direct your browser to :
   ```
   http://localhost:<portNum>
   ```
6. To stop server, go to command prompt and press `Ctrl + C`.
