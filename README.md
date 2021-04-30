# Coffee_Queuer
> Simple Android 9 app to list your coffes ordered by clients/guests, might be useful for cafes or home parties.
Download now from Amazon App Store under name 'Coffe Queuer'!

## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Setup](#setup)
* [Code Examples](#code-emaples)
* [Features](#features)
* [Status](#status)
* [Contact](#contact)

## General info
This project was made in order to easy organization of coffee lovers parties or small cafes. It allows user to quickly add coffee from availibles to queue and remove them. Almost 20 coffes may be chosen. Application limitation is working in host range only.

## Screenshots
![add](https://user-images.githubusercontent.com/56934469/116703865-0b6bc700-a9cb-11eb-8bef-aefbe604085f.png)
![menu](https://user-images.githubusercontent.com/56934469/116703940-1e7e9700-a9cb-11eb-8b58-04c06efb40d9.png)
![remove](https://user-images.githubusercontent.com/56934469/116703944-1fafc400-a9cb-11eb-981e-17afafb18a63.png)

## Technologies
* .NET Standard 2.0
* C# 8.0
* Xamarin

## Setup
Download Visual Studio 2019 with Xamarin, C# and .NET installed. Download and create device with Android 9.0 or higher. Download repository and you're ready to go!
Or if you just want to test it, easiest way is to download from Amazon App Store under name 'Coffe Queuer'.

## Code Examples
This is how short is code for load subpage:
```        
        private CoffeeCounter loadCoffees;

        public AddToQueue(CoffeeCounter content)
        {
            InitializeComponent();

            this.loadCoffees = content;

            ShowAmounts();
        }
```
        
## Features
List of app features
* Adding coffee to queue
* Removing coffee from queue
* Fast and simple navigation

## Status
Project is:  _finished_.

## Contact
Created by [@Quanthis](https://github.com/Quanthis) - don't hesitate to open an issue if you found one!
