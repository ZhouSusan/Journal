# Journal App
## Introduction
<hr style="background:blue" />

Journal is an online application where users can safely create, edit, and view private journal entries in blurb format. The app is designed with simplicity and ease of access for the user. Responsive design allows a wide range of view screens to easily view the app, including mobile devices. Data entry is secure and persisted using MySQL and served using a c# server and framework.

## Features
<hr/>

- Responsive layout design
- Mobile friendly views
- Personal accounts with password protection
- Create, read, update, and deletion of journal entries
- Persisted data
- Animations for ease of use

## Tech Stack
<hr style="background:blue" />

- .Net 5.0
- Asp.net 5.0
- C#
- Bootstrap
- MySQL
- Javascript, HTML, CSS

## Demo
<hr/>
<img alt="Desktop login registration image" src="./imagesReadme/Capture.PNG/" width="500px" height="400px"/>
<img alt="Mobile login registration image" src="./imagesReadme/register_mobile.PNG" height="300px" width="200px"/>

<img alt="Tablet login registration image" src="./imagesReadme/tablet_register.PNG" width="500px" height="400px"/>

<img alt="After deleting an entry image" src="./imagesReadme/afterdelete.PNG" width="800px" height="200px" />

<img alt="Editing an entry image" src="./imagesReadme/edit.PNG" width="600px" height="300px" />


<img alt="Viewing an entry image" src="./imagesReadme/FirstNew.PNG" width="800px" height="200px" />

<img alt="Home page view after logging in image" src="./imagesReadme/home_page.PNG" width="600px" height="200px" />

<img alt="Mobile entry creation image" src="./imagesReadme/mobile_create.PNG" width="400px" height="500px" />

<img alt="Tablet view image" src="./imagesReadme/tablet_size.PNG" width="500px" height="500px" />

## Local Instance Setup
<hr style="background:blue" />

The following instructions are for setting up a local instance to demo the app.
- Clone the repository
- Ensure you have an instance of MySql running.
- Edit your "appsettings.json" file to include the login information for your database instance.
    - Check for "DBInfo" property and ensure the "ConnectionString" is correct.
- You will need .net 5.0 installed before building the app.
- Using visual studio/code, follow the automatic build process after pressing run.
- The local instance will be served on "localhost:5000".
