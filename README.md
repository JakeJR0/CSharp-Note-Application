# Notes Application in C#

## Table of Content
- [Project](#project)
    - [Information](#project-information)
    - [Plan](#project-plan)
- [Application](#application)
    - [User Interface](#ui)
    - [Features](#features)

## Project

### Project Information
The idea of this project is to allow me to both practice and expand my current knowledge of C#, with the current project I have decided that I will be using Windows Forms to make the user interface.
### Project Plan
- User will be able to write text into the application.
- User will be able to save text using the application.
- User will be able to open text files using the application.
- User will be able to reset the application to make new text files.
- The application should be easy to use.

## Application
### User Interface
#### Main Preview
![Main Page Preview](https://github.com/JakeJR0/CSharp-Note-Application/blob/master/Notes%20App/images/Main_Page_View.PNG)


#### Settings Preview
![Settings Page Preview](https://github.com/JakeJR0/CSharp-Note-Application/blob/master/Notes%20App/images/Settings_Page_View.PNG)

### Features


|   Feature | Description |
|   :-----: | :---------: |
| Shortcuts | [Information](#shortcuts) |
| Font Control | [Information](#font-control) |


#### Font Control
Due to the application using windows forms, I was able to use a font dialog box, this allowed the program to get the user to configure the font, once the user has finished modifying the font, the user is able to either apply the changes or disgard the changes by pressing either `OK` or `Cancel` 

![Font Dialog Image](https://github.com/JakeJR0/CSharp-Note-Application/blob/master/Notes%20App/images/Font_Dialog_Image.PNG)

#### Progess Loss Warnings
Since the user will be typing in the application, I have added a safety feature to help prevent the user losing any progress on the application, if the user attempts to close the application where the progress has not been saved the application will prompt the user to save.

![Progess Loss Warning Image](https://github.com/JakeJR0/CSharp-Note-Application/blob/master/Notes%20App/images/Save_Prompt_Image.PNG)
#### Shortcuts

|   Key |   Result  |
| :----:| :-------: |
| Ctrl + N  |   New File    |
| Ctrl + Shift + N  | New Window    |
| Ctrl + O  |   Open File   |
| Ctrl + S  | Save File |
| Ctrl + Shift + S  | Save File As  |
| Ctrl + X  | Exit Program  |
| Alt + F   | Font Editor   |
| Alt + S   | Editor Settings   |
