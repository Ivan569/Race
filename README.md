# Race
"Microsoft .NET platform and C# programming language" # 5 


Topic: Delegates and events.

Goal: 
To consolidate students ' practical skills and theoretical knowledge for working with classes and objects, properties. Learn how to use structures and enumerations. 

Required tools: MS Visual Studio 2013
Documentation: Synopsis, Literature
Estimated execution time: 2 hours.


Requirements for the report: the Report must be issued in the form of an electronic document: program code with comments, conclusions about the results of performed actions, and copies of the screen. The report file size is up to 2 MB with screenshots.


Task 1. the Game "Car racing". 
Develop a car racing game using delegates.
1. in the game, use several types of cars: sports, cars, trucks and buses.
2. Implement the "Race" game. The principle of the game: Cars move from start to finish with speeds that change within the set limits randomly. The winner is the car that came to the finish line first

Recommendations for completing the work
1. Develop an abstract class "car" (Car class). Collect all common fields, properties (for example, speed) and methods (for example, speed) in it.
2. Develop classes of cars with specific implementation of constructors and methods, properties. Add the necessary events to the car classes (for example, the finish line).
3. the game Class must run car competitions, display messages about the current position of cars, and display a message about the car that won the race. Create delegates that allow calling methods from car classes (for example, go to the start, start a race). 
4. the Game ends when one of the cars has driven a certain distance (start in position 0, finish in position 100).   Notification of the end of the race (the arrival of a car at the finish line) is implemented using events.
