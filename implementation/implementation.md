## Implementation 1  

### 1. Introduction (Nicole) 

 Provide a short paragraph that describes your system. This paragraph should contain the value proposition and the description of the main features of the software. At the end of the introduction, include links to your project on GitHub and Trello, which should be upto-date.  

CodeHub is a free, self-paced programming education web-application designed to teach coding to those with no experience. The main features of CodeHub include allowing users to register and login. Once the user is on their account, they are directed to a nice, simplistic homepage that informs users about the application. CodeHub has tabs on the top of the page for navigating from the homepage to a profile, Q&A, and courses. The user can change their username, password and phone number on their profile. 

GitHub link: https://github.com/ind9-nau/CS386-Learn_Coding.git 

### 2. Implemented Requirements (Bailey) 

**(1)**

**Requirement:** “As a user, I want to be able to customize my profile so that the webapp is customized to my information and style” 

**Issue:** https://github.com/ind9-nau/CS386-Learn_Coding/issues/9 

**Pull Request:** https://github.com/ind9-nau/CS386-Learn_Coding/pull/30 

**Implemented by:** Nicole Sylvester  

**Approved by:** Bailey Rosato  

**Print screen:** ![Screenshot (12)](https://user-images.githubusercontent.com/71994157/159208334-745ff381-d8fc-44bd-8d75-b44d0e3a0cd1.png)

**(2)**

**Requirement:** “As a user I want a basic settings menu to easily navigate the webapp.”  

**Issue:** https://github.com/ind9-nau/CS386-Learn_Coding/issues/17 

**Pull Request:** https://github.com/ind9-nau/CS386-Learn_Coding/pull/29 

**Implemented by:** Ian Dennis 

**Approved by:** Ian Dennis  

**Print screen:**  ![Screenshot (15)](https://user-images.githubusercontent.com/71994157/159208708-ba65dbca-333c-4cfa-beca-be2e7f61dc40.png)


### 4. Adopted technologies (Nasya) 

List the adopted technologies with a brief description and justification for choosing them.  

Visual studios – The team decided to use Microsoft Visual Studio as the main platform to code our app. Visual Studio is an IDE designed to develop things like web apps, which is what we are doing, and they have several software development platforms available to aid the process. The team chose to use VS because it is one of the best platforms available for what we are developing, it has GitHub and Docker integrated which benefits the whole process. 

Docker – The team decided to use Docker for deployment mainly because it is already integrated in Visual Studio, and it is the technology we are most familiar with. 

### 5. Learning/training (Nicole) 

Describe the strategies employed by the team to learn the adopted technologies.   

Our team's strategy was to divide up the features we thought we could implement in the given amount of time. We all planned to research and find tutorials on implementing the different features but found that user login and registration was a huge task. We adjusted our strategy and had everyone working on implementing just user login and put some other originally planned features on hold. 

 Visual Studio was a new technology for some group members and got overwhelming quickly. In order to learn the application, we had to do a lot of googling and trial and error. Luckily, there were many Microsoft Visual Studio Tutorials that walked us through the procedures of setting up Visual Studio. In addition, we watched a lot of YouTube videos to figure out how to create our new project and use the built-in git features. We used videos to help us set up user registration and user login as well as create new tabs on our web application.  

As the web application continues to develop, we hope to be able to implement more features that were put on hold including a user-friendly homepage, a simplistic question and answer forum, and a beginner level programming course. 

### 6. Deployment (Bailey) 

Describe how you are deploying your system in production. If you are using AWS, remember that AWS Educate offers free credits for students. See the tutorial at https://docker-curriculum.com/ on how to create a container and deploy it on AWS. Provide a link for the system in production.  

 Our system will be deployed using Docker Desktop through Visual Studio 2022, which will prepare the system for production. Right now, we are using a local server on Visual Studio but once a server is obtained, we will use Docker containers to produce images.  
 
### 7. Licensing (Kelene)

Inform the license you adopted for your source code (remember to configure GitHub accordingly). Explain why you adopted this license. For more information, check https://choosealicense.com/ and http://redhat.slides.com/glikins/open-sourcelicensing-101#/  

Our team chose to adopt the MIT license for our source code. We chose this license because it is one of the most simple open source license agreements. It allows our group to easily make changes to the code. Anyone who has a copy of the software and files can use, copy, modify, merge, distribute, and publish copies of the software. The MIT license has minimal restrictions and lets us work efficiently. 

### 8. Readme File (Ian)

You should also prepare your repository for receiving new contributors. You should prepare a Readme.md file. See an example at https://gist.github.com/PurpleBooth/109311bb0361f32d87a2 In the Readme file, the current version should be stated. You should follow the Semantic Versioning schema (https://semver.org/). Tag the GitHub repository accordingly (https://gitscm.com/book/en/v2/Git-Basics-Tagging).  

Your repository should contain a CONTRIBUTING.md file, a LICENSE file, and a CODE_OF_CONDUCT.md file. Search online for some examples of these files. In this section of the deliverable, put links to these files on GitHub.  

**README**
https://github.com/ind9-nau/CS386-Learn_Coding/blob/main/README.md

**Contributing**
https://github.com/ind9-nau/CS386-Learn_Coding/blob/main/CONTRIBUTING.md

**Code of Conduct**
https://github.com/ind9-nau/CS386-Learn_Coding/blob/main/CODE_OF_CONDUCT.md

**Liscense**
https://github.com/ind9-nau/CS386-Learn_Coding/blob/main/LICENSE

### 9. Look & Feel (Nicole)
Describe the approach you adopted to design your user interface. Include some screenshots. 

During our interviews, we received input about simplicity. We wanted a clean and simple interface that anyone could navigate. The initial development sketches of the interface were used to decide the different tabs we needed to navigate to and the different pages we needed to create. The pages have coming soon messages because for this implementation, we really wanted to create a simple interface and have users be able to register and sign in. However, we plan to add to the Question and Answer Forum and Courses for the next implementation. We are using many of the Visual Studio project generated files as templates and adding and changing the code to make it fit our design.  
![Screenshot (20)](https://user-images.githubusercontent.com/71994157/159210324-1cfd6090-aa8c-491e-9c56-a2ede29dc3ae.png)
![Screenshot (23)](https://user-images.githubusercontent.com/71994157/159210375-11eee07b-cfe4-40ae-ba1e-75bc06f0b8e5.png)
![Screenshot (21)](https://user-images.githubusercontent.com/71994157/159210382-1c7ca6e6-18d2-4d98-b57f-46f6c2e5257d.png)

### 10.Lessons learned (Nasya) 

In retrospective, describe what your team learned during this first release and what you are planning to change for the second release.  

Our project seemed manageable on paper but as we started working on it became more challenging. The software we decided to use is in a language that most of the team did not know, which was a challenge we needed to quickly overcome. VS was also something most of us had not worked with but after some time, we got much more familiarized and comfortable using it. Fortunately, D3. Analysis prepared us with most of the design and model cases we needed to implement, however we learned that the coding part is harder and much more time consuming than we expected. Overall, the most troubles we had were because we didn't know the technology and it was about adjusting, which is not going to be a problem in the future. 

### 11.Demo (Kelene) 

Include a link to a video showing the system working.  

https://youtu.be/ZPn4TRquklc 
