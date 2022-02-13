# Project Requirements

_Team 7: CodeHub\
Febuary 13th, 2022\
Writers: Ricardo Chairez, Ian Dennis, Kelene Moore, Bailey Rosato, Nasya Valenzuela, Nicole Sylvester_


## 1. Positioning

### 1.1 Problem statement
The problem of accessing the world of computer programming affects the general population of learners, the impact of which is limiting their access to the modern world.

### 1.2. Product Position Statement
For anyone interested in learning about coding CodeHub is a free education application that lets you learn the basics of computer literacy and programming at your own pace. Unlike CodeHS, our product allows users to work in groups and is available to everyone. 

### 1.3. Value proposition
CodeHub is a free, self-paced programming education web- application designed to teach coding to all ages at any level of coding experience. 

**Consumer segments:**
- School Districts
- Teachers/ Other Educators
- Early education for K-12 students 
- Supplemental Education for high school and college students 
- Self-paced Learners 
- Employee Training 
- Small Businesses 
- Hobbyist 
- Gamers and Modders 

## 2. Stakeholders
**Users** – Teachers, students, self-paced learners, employees, small businesses\
**Competitors** – CodeHS, Khan academy, CodeAcademy \
**Detractors** – Formal classes \
**Developers** - Ricardo Chairez, Ian Dennis, Kelene Moore, Bailey Rosato, Nicole Sylvester, Nasya Valenzuela 

## 3. Functional requirements (features)
- Work in groups (Teams) 
  - Small groups to collaborate in a project 
  - Moderator Role(“Teacher”) 
    - Can see progress/grade assignments 
    - Can manage community hub, delete comments, ban people 
- Community Hub/Q&A forum 
- Pretest/Placement tests 
- Open ended projects 
- Customizable profiles 
- Reminders 
- Rewards/Ranking system 
  - Streak tracker   
  - Mentor “rank” 
- Tutorials and Reference videos 
- Orientation/reference for programming 
  - How different languages are used 
  - Where to find more resources 
  - Computer architecture 101 
  - Etc.
   
## 4. Non-functional requirements
- Ease of use 
- Availability 
- Compatibility  
- Description of every function on application 
- Toggling options for all “extra” features 
  - I.e. rankings, chats, group work 
- Videos aren’t more than 15 minutes each 

## 5. MVP
- The features we plan to implement early on include three beginner courses (python, java, and web dev)  
  - Basic in-app IDE for each course 
- Two larger, open-ended projects for each course 
- Computer literacy pseudo-course 
  - Lots of explanations along with basic exercises 
- Q&A forum 
- Basic achievements 
  - Courses completed 
  - Days in a row practiced 
  - Questions asked/answered in forum 
- Reminder emails 
- User profiles/accounts 
  - Including basic settings menu 
  
**Testing:**
- WOZ for user interface and interactions 
- Direct implementation for all other features

## 6. Use cases

### 6.1. Use case diagrams
<img alt="image" src="https://user-images.githubusercontent.com/71862426/153727318-0a3d02e0-d705-43e1-8377-c0d23bb8b537.png">

### 6.2. Use case descriptions
**Use Case**: Manage Community Hub\
**Actor**: Moderator\
**Description**: Moderator can delete, ban, and community posts/profiles as appropriate.\
**Preconditions**: Must have downloaded application and have a moderator profile.\
**Postconditions**: Normal user account will be changed as outlined in description. The community hub has been updated to reflect these descriptions\
**Main Flow**:
1. Case begins when Moderator visits the community hub.
2. Moderator views an outstanding community post or profile.\
  a. Alternative flow 1.\
  b. Alternative flow 2.\
  c. Alternative flow 3.\
  d. Alternative flow 4.
3. End use case.\
**Alternative Flow 1:**
1. The post observed by the moderator is exceptionally helpful or relevent.
2. The Moderator marks the post with a commendation.\
**Alternative Flow 2:**
1. The post observed by the moderator is derogatory, irrelevent, or violates other community guidelines not listed here.
2. The Moderator removes the post from the community hub.
3. The Moderator messages the owner of the post with a warning and a description of why their post was removed.\
**Alternative Flow 3:**
1. The User observed by the Moderator has been consistenly active and helpful in the community.
2. The Moderator awards the user with commendations.\
**Alternative Flow 4:**
1. The User observed by the Moderator has consitently violated the community guidelines.
2. The Moderator permantently bans or temporarily suspends the User's community access.
3. The Moderator messages the owner of the post with a warning and description of why their account access was modified.

**Use Case**: Participate in a Community Hub\
**Actor**: User\
**Description**: Users will be able to submit forum posts and responses to a community hub.\
**Preconditions**: User must have application downloaded and thier profile must be verfied to be run by a person.\
**Postconditions**: User will become an active participant of the community hub.\
**Main Flow**:
1. User navigates to community hub location on application.
2. User creates a community post or adds to a post that has already been created.
3. End use case

## 7. User stories

**User story 1**:“As a user, I want to read about the purpose of programming languages first so I can learn the one that suites my needs.” \
Priority: 2 Hours: 3 

**User story 2**:“As a user, I want there to be a community hub so I can communicate with others and ask questions.” \
Priority: 1 Hours:  20 

**User story 3**:“As a user, I want to customize my profile so that the webapp is personalized to my style.” \
Priority: 1 Hours: 13 

**User story 4**:“As a user, I want the option to jump straight to higher level content, so I don’t feel my time is wasted.” \
Priority: 2 Hours: 8 

**User story 5**:“As a moderator, I want to be able to track and manage the people I’m helping so that I know they are learning the content.” \
Priority: 2 Hours: 10 

**User story 6**:“As a user, I want tutorial videos and manuals so I can learn about programming before trying to implement it.” \
Priority: 3 Hours: 5

**User story 7**:“As a user, I want to receive notifications, so I don’t forget to practice.” \
Priority: 1 Hours: 7 

**User story 8**:“As a user, I want to be able to work in small teams so that I am better prepared for an industry job.” \
Priority: 3 Hours: 9 

**User story 9**:“As a user, I want there to be able to share and compare my progress with other users so that I have another way to interact with the community.” \
Priority: 3 Hours: 10 

**User story 10**:“As a moderator, I want to be able to delete community posts and ban users so I can help maintain the CodeHub community.” \
Priority: 1 Hours: 10 

**User story 11**:“As a user, I want a basic settings menu to easily navigate the webapp.” \
Priority: 1 Hours: 5 

**User story 12**:“As a user, I want to be able to achieve an experienced programmer rank so I can help those still learning.” \
Priority: 3 Hours: 8 

## 8. Issue tracker
**GitHub**![Screenshot (45)](https://user-images.githubusercontent.com/71862426/153727669-baf0c856-3fe8-4e6e-9bcc-6ec5be589111.png)

