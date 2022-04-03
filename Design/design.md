## Design

### 1. Description (Nicole)
Provide 1-2 paragraphs to describe your system. This will help you understand the context of your design decisions. You can reuse and update text from the previous deliverables.  

CodeHub is a free, self-paced programming education web-application designed to teach coding to those with no experience. The primary features of CodeHub include allowing users to register and login. Once the user has an account, they are directed to a nice, simplistic homepage that informs users about the application. CodeHub has tabs on the top of the page for navigating from the homepage to a profile, Q&A, and courses. The user can change their username, password, and phone number on their profile. 

CodeHub is still in the early stages of development and is available to select 	users. This application offers a simplistic interface that is easy to navigate, and users have the ability to personalize their profile. In the next implementation, CodeHub will have a simple IDE that is user friendly and located under the Courses tab. 

### 2. Architecture (Ian)
Present a diagram of the high-level architecture of your system. Use a UML package diagram to describe the main modules and how they interrelate. 
Provide a brief rationale of your architecture explaining why you designed it that way. 

This architecture was designed with a standard web application in mind. It needs to receive interactions from clients and web services (the web services will be used for code IDEs).  Both of these will need their own interfaces so they can interact with our application. Beyond that the Application Layer is meant to give feedback to our users and coordinate any communication between users. The Security Layer is meant to protect users and their privacy. Lastly, the data layer is meant to handle most of the processing and any storage/retrieval of information from the server. This setup should lead to maintainable and expandable application. Layouts similar to this seemed to be standard for systems such as ours. 

### 3. Class Diagram (Kelene) 
Present a refined class diagram of your system, including implementation details such as visibilities, attributes to represent associations, attribute types, return types, parameters, etc. The class diagram should match the code you have produced so far, but not be limited to it (e.g., it can contain classes not implemented yet). 
The difference between this class diagram and the one that you presented in D.3 is that the last focuses on the conceptual model of the domain while the former reflects the implementation. Therefore, the implementation details are relevant in this case. 

### 4. Sequence Diagram (Nicole)  
Present a sequence diagram that represents how the objects in your system interact for a specific use case. Also include the use case description in this section. The sequence diagram should be consistent with the class diagram and architecture. 

### 5. Design Patterns (Bailey) 
Split this section into 2 subsections. For each subsection, present a UML class diagram showing the application of a design pattern to your system (a different pattern for each section). Each class diagram should contain only the classes involved in the specific pattern (you don’t need to represent the whole system). Choose patterns from two different categories: Behavioral, Structural, and Creational. You are not limited to design patterns studied in class. 
Your system may not be appropriate for any design pattern. In this case, for didactic purposes, be creative and extend a little bit the scope of your system to make the design patterns appropriate. 
Implement each design pattern in your system and provide GitHub links to the corresponding classes. 

### 6. Design Principles (Nasya) 
How does your design observe the SOLID principles? Provide a short description of followed principles giving concrete examples from your classes. 
