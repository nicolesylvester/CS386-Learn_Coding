## Design

### 1. Description (Nicole)
Provide 1-2 paragraphs to describe your system. This will help you understand the context of your design decisions. You can reuse and update text from the previous deliverables.  

CodeHub is a free, self-paced programming education web-application designed to teach coding to those with no experience. The primary features of CodeHub include allowing users to register and login. Once the user has an account, they are directed to a nice, simplistic homepage that informs users about the application. CodeHub has tabs on the top of the page for navigating from the homepage to a profile, Q&A, and courses. The user can change their username, password, and phone number on their profile. 

CodeHub is still in the early stages of development and is available to select 	users. This application offers a simplistic interface that is easy to navigate, and users have the ability to personalize their profile. In the next implementation, CodeHub will have a simple IDE that is user friendly and located under the Courses tab. 

### 2. Architecture (Ian)
Present a diagram of the high-level architecture of your system. Use a UML package diagram to describe the main modules and how they interrelate. 

Provide a brief rationale of your architecture explaining why you designed it that way. 

This architecture was designed with a standard web application in mind. It needs to receive interactions from clients and web services (the web services will be used for code IDEs).  Both of these will need their own interfaces so they can interact with our application. Beyond that the Application Layer is meant to give feedback to our users and coordinate any communication between users. The Security Layer is meant to protect users and their privacy. Lastly, the data layer is meant to handle most of the processing and any storage/retrieval of information from the server. This setup should lead to maintainable and expandable application. Layouts similar to this seemed to be standard for systems such as ours. 
![CS386 UML Architecture](https://user-images.githubusercontent.com/71994185/161472171-f8b798f1-745c-47dc-82fd-53a0f54554e7.jpeg)

### 3. Class Diagram (Kelene)
Present a refined class diagram of your system, including implementation details such as visibilities, attributes to represent associations, attribute types, return types, parameters, etc. The class diagram should match the code you have produced so far, but not be limited to it (e.g., it can contain classes not implemented yet). The difference between this class diagram and the one that you presented in D.3 is that the last focuses on the conceptual model of the domain while the former reflects the implementation. Therefore, the implementation details are relevant in this case. 

![Analysis Model](https://user-images.githubusercontent.com/71994157/161472959-5957a471-18c8-445c-b6b3-661c8e057524.jpg)


### 4. Sequence Diagram (Nicole)
Present a sequence diagram that represents how the objects in your system interact for a specific use case. Also include the use case description in this section. The sequence diagram should be consistent with the class diagram and architecture. 

![SequenceDiagram (1)](https://user-images.githubusercontent.com/71994185/161448243-740c98ca-6815-4a9a-9e69-4642016482f0.jpg)

##### Use Case Description: 
**Use Case:** Login to Profile  
**Actor:** Web application User  
**Description:** A user will login to their account  
**Preconditions:** User has the application open and has clicked on the “Login” tab  
**Postconditions:** The user has logged in and can navigate the application  
**Main Flow:** 
1. The user enters an email 
2. The user enters their password 
3. The user clicks Login 
4. The system redirects the user to the Homepage 

**Alternative Flow:** 
1. a. The user’s email is not registered 
      - The system shows the not registered error message and prompts user to create an account  
   b. Use Case Ends 
3. a. The user’s passwords or email are incorrect 
      - The system shows the incorrect information error message to the user  
   b. Use Case continues at 1 

### 5. Design Patterns (Bailey)
Split this section into 2 subsections. For each subsection, present a UML class diagram showing the application of a design pattern to your system (a different pattern for each section). Each class diagram should contain only the classes involved in the specific pattern (you don’t need to represent the whole system). Choose patterns from two different categories: Behavioral, Structural, and Creational. You are not limited to design patterns studied in class. Your system may not be appropriate for any design pattern. In this case, for didactic purposes, be creative and extend a little bit the scope of your system to make the design patterns appropriate. Implement each design pattern in your system and provide GitHub links to the corresponding classes. 

##### (1) Structural: Decorator Pattern
![decoratorpattern](https://user-images.githubusercontent.com/71994157/161448724-04bf9931-385f-4ee5-bf80-b06f6861ac0b.jpg)

##### (2) Behavioral: Observer Pattern 

![observerpattern](https://user-images.githubusercontent.com/71994157/161448730-2322269b-e284-413e-8d91-e513f7dce7f9.jpg)

### 6. Design Principles 
How does your design observe the SOLID principles? Provide a short description of followed
principles giving concrete examples from your classes. 

**Single Responsibility Principle:** States that each class should only have one responsibility. The Notifications class is an example of this because it only sends a message to the user once preferences are selected. 

<img width="250" alt="singletonclass" src="https://user-images.githubusercontent.com/71994157/161480875-dd18ea55-3696-45cc-89cb-dae7eecb3530.jpg">

**Open/Closed Principle:** Software entities should be open for extension but closed for modification. The GroupChat class is an example of the principle becauseit extends the information of the Group class, but cannot modify the attributes of the Group class. 

<img width="250" alth="openclosedprinciple" src="https://user-images.githubusercontent.com/71994157/161481431-a8143477-6b48-4764-ba13-155a599404b2.jpg">

**Liskov Substitution Principle:** “any subclass object should be substitutable for the superclass object from which it is derived” <br> 
In this case you can replace notifDecorator with emailDecorator, or SMSDecorator, depending on the situation without it affecting the program. 

<img width="250" alt="Screenshot 2022-04-03 214447" src="https://user-images.githubusercontent.com/71862426/161476008-2f7b743a-58ff-4f23-bc40-75c4e0de03fd.png">

**Interface Segregation Principle:** “many client-specific interfaces are better than one general purpose interface.” <br>
We see this principle in our class diagram when we use different interfaces. The Unit Course, Settings, and Group all modify the Homepage interface specified for the user. These split the Homepage interface so that the users only get information specific to their interests. 
<img width="250" alt="Screenshot (33)" src="https://user-images.githubusercontent.com/71994185/161482416-0b307acc-1bd6-4735-b828-54e59909de7f.png">


**Dependency Inversion Principle:** High-level modules, which provide complex logic, should be easily reusable and unaffected by changes in modules under. Here we see how messageObserver manages sendMessage and receiveMessage, GroupChat depends on messageObserver(an abstraction) to handle the other classes. 

<img width="250" alt="Screenshot 2022-04-03 214954" src="https://user-images.githubusercontent.com/71862426/161475953-79d63dd4-28bc-49b4-9046-f53ec521a497.png">

