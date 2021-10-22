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

## Run the Builds

**For Windows build**

1. Navigate to `Build\WinBuild` folder and open `Foodmenu.exe`.

**For WebGL build**

The __correct__ way to run Unity-WebGL build locally is to use a simple server.

1. Install Servez, a simple web server for local web development, from the link [here](https://greggman.github.io/servez/).
2. Run Servez and locate `Build\WebGL` in __Folder to Serve__.
3. Click __Start__ and then __Launch Browser__. Now the WebGL build will run.
4. To stop server, Click __Stop__ in Servez.

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
